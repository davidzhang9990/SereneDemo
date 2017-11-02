using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web;
using Serenity.Util.Offices.Model;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;

namespace Serenity.Util.Offices
{

    ///描 述：NPOI Excel DataTable操作类
    public class ExcelHelper
    {
        #region Excel导出方法 ExcelDownload

        /// <summary>
        /// Excel导出下载
        /// </summary>
        /// <param name="dtSource">DataTable数据源</param>
        /// <param name="excelConfig">导出设置包含文件名、标题、列设置</param>
        public static void ExcelDownload(DataTable dtSource, ExcelConfig excelConfig)
        {
            HttpContext curContext = HttpContext.Current;
            // 设置编码和附件格式
            curContext.Response.ContentType = "application/ms-excel";
            curContext.Response.ContentEncoding = Encoding.UTF8;
            curContext.Response.Charset = "";
            curContext.Response.AppendHeader("Content-Disposition",
                "attachment;filename=" + HttpUtility.UrlEncode(excelConfig.FileName, Encoding.UTF8));
            //调用导出具体方法Export()
            curContext.Response.BinaryWrite(ExportMemoryStream(dtSource, excelConfig).GetBuffer());
            curContext.Response.End();
        }

        /// <summary>
        /// Excel导出下载
        /// </summary>
        /// <param name="list">数据源</param>
        /// <param name="templdateName">模板文件名</param>
        /// <param name="newFileName">文件名</param>
        public static void ExcelDownload(List<TemplateMode> list, string templdateName, string newFileName)
        {
            HttpResponse response = System.Web.HttpContext.Current.Response;
            response.Clear();
            response.Charset = "UTF-8";
            response.ContentType = "application/vnd-excel";//"application/vnd.ms-excel";
            System.Web.HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment; filename=" + newFileName));
            System.Web.HttpContext.Current.Response.BinaryWrite(ExportListByTempale(list, templdateName).ToArray());
        }

        /// <summary>
        /// 自定义导出Excel
        /// </summary>
        /// <param name="dropdownList">下拉菜单字符串</param>
        /// <param name="rowCount">行数</param>
        /// <param name="templdateName">模板文件</param>
        /// <param name="newFileName">导出文件名称</param>
        public static void ExcelCustomDownload(string[] dropdownList, int rowCount, string templdateName, string newFileName, string shareType)
        {
            HttpResponse response = System.Web.HttpContext.Current.Response;
            response.Clear();
            response.Charset = "UTF-8";
            response.ContentType = "application/vnd-excel";//"application/vnd.ms-excel";

            var fileStream = ExportListByTempale(dropdownList, rowCount, templdateName, shareType).ToArray();
            long fileSize = fileStream.Length;
            //加上设置大小下载下来的.xlsx文件打开时才没有错误
            HttpContext.Current.Response.AddHeader("Content-Length", fileSize.ToString());
            HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment; filename=" + newFileName));
            HttpContext.Current.Response.BinaryWrite(fileStream);
        }

        /// <summary>
        /// 自定义导出Excel模板方法
        /// </summary>
        /// <param name="dropdownList">下拉菜单字符串</param>
        /// <param name="rowCount">行数</param>
        /// <param name="templdateName">模板文件</param>
        /// <returns></returns>
        public static MemoryStream ExportListByTempale(string[] dropdownList, int rowCount, string templdateName, string shareType)
        {
            try
            {
                string templatePath = HttpContext.Current.Server.MapPath("/") + "/Resource/ExcelTemplate/";
                string templdateName1 = string.Format("{0}{1}", templatePath, templdateName);

                FileStream fileStream = new FileStream(templdateName1, FileMode.Open, FileAccess.Read);
                ISheet sheet = null;
                if (templdateName.IndexOf(".xlsx") == -1)//2003
                {
                    HSSFWorkbook hssfworkbook = new HSSFWorkbook(fileStream);
                    sheet = hssfworkbook.GetSheetAt(0);
                    ICellStyle mstyle = hssfworkbook.CreateCellStyle();
                    mstyle.DataFormat = 4;
                    SetPurchaseOrder(sheet, rowCount, shareType, mstyle);

                    //第一列设置成 下拉菜单
                    CellRangeAddressList regions = new CellRangeAddressList(0, rowCount + 1, 0, 0);
                    DVConstraint constraint = DVConstraint.CreateExplicitListConstraint(dropdownList);
                    HSSFDataValidation dataValidate = new HSSFDataValidation(regions, constraint);
                    sheet.AddValidationData(dataValidate);

                    sheet.ForceFormulaRecalculation = true;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        hssfworkbook.Write(ms);
                        ms.Flush();
                        return ms;
                    }
                }
                else//2007
                {
                    XSSFWorkbook xssfworkbook = new XSSFWorkbook(fileStream);
                    ICellStyle mstyle = xssfworkbook.CreateCellStyle();
                    mstyle.DataFormat = 4;
                    sheet = xssfworkbook.GetSheetAt(0);
                    SetPurchaseOrder(sheet, rowCount, shareType, mstyle);

                    XSSFDataValidationHelper dvHelper = new XSSFDataValidationHelper((XSSFSheet)sheet);
                    XSSFDataValidationConstraint dvConstraint = (XSSFDataValidationConstraint)dvHelper.CreateExplicitListConstraint(dropdownList);
                    CellRangeAddressList addressList = new CellRangeAddressList(0, rowCount + 1, 0, 0);
                    XSSFDataValidation validation = (XSSFDataValidation)dvHelper.CreateValidation(dvConstraint, addressList);
                    // 07默认setSuppressDropDownArrow(true);  
                    // validation.setSuppressDropDownArrow(true);  
                    // validation.setShowErrorBox(true);  
                    sheet.AddValidationData(validation);

                    sheet.ForceFormulaRecalculation = true;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        xssfworkbook.Write(ms);
                        ms.Flush();
                        return ms;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 自定义单元格赋值
        /// </summary>
        /// <param name="sheet">单元格</param>
        /// <param name="rowCount">行数</param>
        /// <param name="shareType">分摊类型1：重量分摊2：体积分摊</param>
        /// <param name="mstyle">格式化样式 formate(0.00)</param>
        private static void SetPurchaseOrder(ISheet sheet, int rowCount, string shareType, ICellStyle mstyle)
        {
            for (var i = 1; i <= rowCount; i++)
            {
                IRow row = null;
                ICell cell7 = null;
                ICell cell8 = null;
                row = sheet.GetRow(i);
                if (row == null)
                {
                    row = sheet.CreateRow(i);
                }
                cell7 = row.GetCell(7);
                if (cell7 == null)
                {
                    cell7 = row.CreateCell(7);
                }
                cell8 = row.GetCell(8);
                if (cell8 == null)
                {
                    cell8 = row.CreateCell(8);
                }

                cell7.SetCellFormula("E" + (i + 1) + "*F" + (i + 1) + "*G" + (i + 1) + "/1000000");
                cell7.CellStyle = mstyle;
                cell8.SetCellValue(0.00);
                cell8.CellStyle = mstyle;
            }
        }


        #endregion Excel导出方法 ExcelDownload

        #region DataTable导出到Excel文件excelConfig中FileName设置为全路径

        /// <summary>
        /// DataTable导出到Excel文件 Export()
        /// </summary>
        /// <param name="dtSource">DataTable数据源</param>
        /// <param name="excelConfig">导出设置包含文件名、标题、列设置</param>
        public static void ExcelExport(DataTable dtSource, ExcelConfig excelConfig)
        {
            using (MemoryStream ms = ExportMemoryStream(dtSource, excelConfig))
            {
                using (FileStream fs = new FileStream(excelConfig.FileName, FileMode.Create, FileAccess.Write))
                {
                    byte[] data = ms.ToArray();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                }
            }
        }

        #endregion DataTable导出到Excel文件excelConfig中FileName设置为全路径

        #region DataTable导出到Excel的MemoryStream

        /// <summary>
        /// DataTable导出到Excel的MemoryStream Export()
        /// </summary>
        /// <param name="dtSource">DataTable数据源</param>
        /// <param name="excelConfig">导出设置包含文件名、标题、列设置</param>
        public static MemoryStream ExportMemoryStream(DataTable dtSource, ExcelConfig excelConfig)
        {
            //修改自定义字段导出报错的bug20170119 by-xm
            List<string> strCol = new List<string>();
            for (int i = 0; i < dtSource.Columns.Count; i++)
            {
                int flag = 0;
                DataColumn column = dtSource.Columns[i];
                for (int j = 0; j < excelConfig.ColumnEntity.Count; j++)
                {
                    if (column.ColumnName == excelConfig.ColumnEntity[j].Column)
                    {
                        flag++;
                        break;
                    }
                }
                if (flag == 0)
                {
                    strCol.Add(column.ColumnName);
                }
            }
            if (strCol.Count > 0)
            {
                for (int k = 0; k < strCol.Count; k++)
                {
                    dtSource.Columns.Remove(strCol[k]);
                }
            }

            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet();

            #region 右击文件 属性信息

            {
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "NPOI";
                workbook.DocumentSummaryInformation = dsi;

                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Author = "刘晓雷"; //填加xls文件作者信息
                si.ApplicationName = "力软信息"; //填加xls文件创建程序信息
                si.LastAuthor = "刘晓雷"; //填加xls文件最后保存者信息
                si.Comments = "刘晓雷"; //填加xls文件作者信息
                si.Title = "标题信息"; //填加xls文件标题信息
                si.Subject = "主题信息";//填加文件主题信息
                si.CreateDateTime = System.DateTime.Now;
                workbook.SummaryInformation = si;
            }

            #endregion 右击文件 属性信息

            #region 设置标题样式

            ICellStyle headStyle = workbook.CreateCellStyle();
            int[] arrColWidth = new int[dtSource.Columns.Count];
            string[] arrColName = new string[dtSource.Columns.Count];//列名
            ICellStyle[] arryColumStyle = new ICellStyle[dtSource.Columns.Count];//样式表
            headStyle.Alignment = HorizontalAlignment.Center; // ------------------
            if (excelConfig.Background != new Color())
            {
                if (excelConfig.Background != new Color())
                {
                    headStyle.FillPattern = FillPattern.SolidForeground;
                    headStyle.FillForegroundColor = GetXLColour(workbook, excelConfig.Background);
                }
            }
            IFont font = workbook.CreateFont();
            font.FontHeightInPoints = excelConfig.TitlePoint;
            if (excelConfig.ForeColor != new Color())
            {
                font.Color = GetXLColour(workbook, excelConfig.ForeColor);
            }
            font.Boldweight = 700;
            headStyle.SetFont(font);

            #endregion 设置标题样式

            #region 列头及样式

            ICellStyle cHeadStyle = workbook.CreateCellStyle();
            cHeadStyle.Alignment = HorizontalAlignment.Center; // ------------------
            IFont cfont = workbook.CreateFont();
            cfont.FontHeightInPoints = excelConfig.HeadPoint;
            cHeadStyle.SetFont(cfont);

            #endregion 列头及样式

            #region 设置内容单元格样式

            foreach (DataColumn item in dtSource.Columns)
            {
                ICellStyle columnStyle = workbook.CreateCellStyle();
                columnStyle.Alignment = HorizontalAlignment.Center;
                arrColWidth[item.Ordinal] = Encoding.GetEncoding(936).GetBytes(item.ColumnName.ToString()).Length;
                arrColName[item.Ordinal] = item.ColumnName.ToString();
                if (excelConfig.ColumnEntity != null)
                {
                    ColumnEntity columnentity = excelConfig.ColumnEntity.Find(t => t.Column == item.ColumnName);
                    if (columnentity != null)
                    {
                        arrColName[item.Ordinal] = columnentity.ExcelColumn;
                        if (columnentity.Width != 0)
                        {
                            arrColWidth[item.Ordinal] = columnentity.Width;
                        }
                        if (columnentity.Background != new Color())
                        {
                            if (columnentity.Background != new Color())
                            {
                                columnStyle.FillPattern = FillPattern.SolidForeground;
                                columnStyle.FillForegroundColor = GetXLColour(workbook, columnentity.Background);
                            }
                        }
                        if (columnentity.Font != null || columnentity.Point != 0 || columnentity.ForeColor != new Color())
                        {
                            IFont columnFont = workbook.CreateFont();
                            columnFont.FontHeightInPoints = 10;
                            if (columnentity.Font != null)
                            {
                                columnFont.FontName = columnentity.Font;
                            }
                            if (columnentity.Point != 0)
                            {
                                columnFont.FontHeightInPoints = columnentity.Point;
                            }
                            if (columnentity.ForeColor != new Color())
                            {
                                columnFont.Color = GetXLColour(workbook, columnentity.ForeColor);
                            }
                            columnStyle.SetFont(font);
                        }
                        columnStyle.Alignment = getAlignment(columnentity.Alignment);
                    }
                }
                arryColumStyle[item.Ordinal] = columnStyle;
            }
            if (excelConfig.IsAllSizeColumn)
            {
                #region 根据列中最长列的长度取得列宽

                for (int i = 0; i < dtSource.Rows.Count; i++)
                {
                    for (int j = 0; j < dtSource.Columns.Count; j++)
                    {
                        if (arrColWidth[j] != 0)
                        {
                            int intTemp = Encoding.GetEncoding(936).GetBytes(dtSource.Rows[i][j].ToString()).Length;
                            if (intTemp > arrColWidth[j])
                            {
                                arrColWidth[j] = intTemp;
                            }
                        }
                    }
                }

                #endregion 根据列中最长列的长度取得列宽
            }

            #endregion 设置内容单元格样式

            ICellStyle dateStyle = workbook.CreateCellStyle();
            IDataFormat format = workbook.CreateDataFormat();
            dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");
            int rowIndex = 0;
            foreach (DataRow row in dtSource.Rows)
            {
                #region 新建表，填充表头，填充列头，样式

                if (rowIndex == 65535 || rowIndex == 0)
                {
                    if (rowIndex != 0)
                    {
                        sheet = workbook.CreateSheet();
                    }

                    #region 表头及样式

                    {
                        if (excelConfig.Title != null)
                        {
                            IRow headerRow = sheet.CreateRow(0);
                            if (excelConfig.TitleHeight != 0)
                            {
                                headerRow.Height = (short)(excelConfig.TitleHeight * 20);
                            }
                            headerRow.HeightInPoints = 25;
                            headerRow.CreateCell(0).SetCellValue(excelConfig.Title);
                            headerRow.GetCell(0).CellStyle = headStyle;
                            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, dtSource.Columns.Count - 1)); // ------------------
                        }
                    }

                    #endregion 表头及样式

                    #region 列头及样式

                    {
                        IRow headerRow = sheet.CreateRow(1);

                        #region 如果设置了列标题就按列标题定义列头，没定义直接按字段名输出

                        foreach (DataColumn column in dtSource.Columns)
                        {
                            headerRow.CreateCell(column.Ordinal).SetCellValue(arrColName[column.Ordinal]);
                            headerRow.GetCell(column.Ordinal).CellStyle = cHeadStyle;
                            //设置列宽
                            if (arrColWidth[column.Ordinal] > 255) arrColWidth[column.Ordinal] = 254;//修改by 杨孟源 判断如果大于255则变为254
                            sheet.SetColumnWidth(column.Ordinal, (arrColWidth[column.Ordinal] + 1) * 256);
                        }

                        #endregion 如果设置了列标题就按列标题定义列头，没定义直接按字段名输出
                    }

                    #endregion 列头及样式

                    rowIndex = 2;
                }

                #endregion 新建表，填充表头，填充列头，样式

                #region 填充内容

                IRow dataRow = sheet.CreateRow(rowIndex);
                foreach (DataColumn column in dtSource.Columns)
                {
                    ICell newCell = dataRow.CreateCell(column.Ordinal);
                    newCell.CellStyle = arryColumStyle[column.Ordinal];
                    string drValue = row[column].ToString();
                    SetCell(newCell, dateStyle, column.DataType, drValue);
                }

                #endregion 填充内容

                rowIndex++;
            }
            using (MemoryStream ms = new MemoryStream())
            {
                workbook.Write(ms);
                ms.Flush();
                ms.Position = 0;
                return ms;
            }
        }

        #endregion DataTable导出到Excel的MemoryStream

        #region ListExcel导出(加载模板)

        /// <summary>
        /// List根据模板导出ExcelMemoryStream
        /// </summary>
        /// <param name="list"></param>
        /// <param name="templdateName"></param>
        public static MemoryStream ExportListByTempale(List<TemplateMode> list, string templdateName)
        {
            try
            {
                string templatePath = HttpContext.Current.Server.MapPath("/") + "/Resource/ExcelTemplate/";
                string templdateName1 = string.Format("{0}{1}", templatePath, templdateName);

                FileStream fileStream = new FileStream(templdateName1, FileMode.Open, FileAccess.Read);
                ISheet sheet = null;
                if (templdateName.IndexOf(".xlsx") == -1)//2003
                {
                    HSSFWorkbook hssfworkbook = new HSSFWorkbook(fileStream);
                    sheet = hssfworkbook.GetSheetAt(0);
                    SetPurchaseOrder(sheet, list);
                    sheet.ForceFormulaRecalculation = true;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        hssfworkbook.Write(ms);
                        ms.Flush();
                        return ms;
                    }
                }
                else//2007
                {
                    XSSFWorkbook xssfworkbook = new XSSFWorkbook(fileStream);
                    sheet = xssfworkbook.GetSheetAt(0);
                    SetPurchaseOrder(sheet, list);
                    sheet.ForceFormulaRecalculation = true;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        xssfworkbook.Write(ms);
                        ms.Flush();
                        return ms;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 赋值单元格
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="list"></param>
        private static void SetPurchaseOrder(ISheet sheet, List<TemplateMode> list)
        {
            try
            {
                foreach (var item in list)
                {
                    IRow row = null;
                    ICell cell = null;
                    row = sheet.GetRow(item.row);
                    if (row == null)
                    {
                        row = sheet.CreateRow(item.row);
                    }
                    cell = row.GetCell(item.cell);
                    if (cell == null)
                    {
                        cell = row.CreateCell(item.cell);
                    }
                    cell.SetCellValue(item.value);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion ListExcel导出(加载模板)

        #region 设置表格内容

        private static void SetCell(ICell newCell, ICellStyle dateStyle, Type dataType, string drValue)
        {
            switch (dataType.ToString())
            {
                case "System.String"://字符串类型
                    newCell.SetCellValue(drValue);
                    break;

                case "System.DateTime"://日期类型
                    System.DateTime dateV;
                    if (System.DateTime.TryParse(drValue, out dateV))
                    {
                        newCell.SetCellValue(dateV);
                    }
                    else
                    {
                        newCell.SetCellValue("");
                    }
                    newCell.CellStyle = dateStyle;//格式化显示
                    break;

                case "System.Boolean"://布尔型
                    bool boolV = false;
                    bool.TryParse(drValue, out boolV);
                    newCell.SetCellValue(boolV);
                    break;

                case "System.Int16"://整型
                case "System.Int32":
                case "System.Int64":
                case "System.Byte":
                    int intV = 0;
                    int.TryParse(drValue, out intV);
                    newCell.SetCellValue(intV);
                    break;

                case "System.Decimal"://浮点型
                case "System.Double":
                    double doubV = 0;
                    double.TryParse(drValue, out doubV);
                    newCell.SetCellValue(doubV);
                    break;

                case "System.DBNull"://空值处理
                    newCell.SetCellValue("");
                    break;

                default:
                    newCell.SetCellValue("");
                    break;
            }
        }

        #endregion 设置表格内容

        #region 从Excel导入

        /// <summary>
        /// 读取excel ,默认第一行为标头
        /// </summary>
        /// <param name="strFileName">excel文档路径</param>
        /// <returns></returns>
        public static DataTable ExcelImport(string strFileName)
        {
            DataTable dt = new DataTable();

            ISheet sheet = null;
            using (FileStream file = new FileStream(strFileName, FileMode.Open, FileAccess.Read))
            {
                if (strFileName.IndexOf(".xlsx") == -1)//2003
                {
                    HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
                    sheet = hssfworkbook.GetSheetAt(0);
                }
                else//2007
                {
                    XSSFWorkbook xssfworkbook = new XSSFWorkbook(file);
                    sheet = xssfworkbook.GetSheetAt(0);
                }
            }

            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

            IRow headerRow = sheet.GetRow(0);
            int cellCount = headerRow.LastCellNum;

            for (int j = 0; j < cellCount; j++)
            {
                ICell cell = headerRow.GetCell(j);
                dt.Columns.Add(cell.ToString());
            }

            for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                DataRow dataRow = dt.NewRow();

                for (int j = row.FirstCellNum; j < cellCount; j++)
                {
                    if (row.GetCell(j) != null)
                        dataRow[j] = row.GetCell(j).ToString();
                }

                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        #endregion 从Excel导入

        #region RGB颜色转NPOI颜色

        private static short GetXLColour(HSSFWorkbook workbook, Color SystemColour)
        {
            short s = 0;
            HSSFPalette XlPalette = workbook.GetCustomPalette();
            NPOI.HSSF.Util.HSSFColor XlColour = XlPalette.FindColor(SystemColour.R, SystemColour.G, SystemColour.B);
            if (XlColour == null)
            {
                if (NPOI.HSSF.Record.PaletteRecord.STANDARD_PALETTE_SIZE < 255)
                {
                    XlColour = XlPalette.FindSimilarColor(SystemColour.R, SystemColour.G, SystemColour.B);
                    s = XlColour.Indexed;
                }
            }
            else
                s = XlColour.Indexed;
            return s;
        }

        #endregion RGB颜色转NPOI颜色

        #region 设置列的对齐方式

        /// <summary>
        /// 设置对齐方式
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        private static HorizontalAlignment getAlignment(string style)
        {
            switch (style)
            {
                case "center":
                    return HorizontalAlignment.Center;

                case "left":
                    return HorizontalAlignment.Left;

                case "right":
                    return HorizontalAlignment.Right;

                case "fill":
                    return HorizontalAlignment.Fill;

                case "justify":
                    return HorizontalAlignment.Justify;

                case "centerselection":
                    return HorizontalAlignment.CenterSelection;

                case "distributed":
                    return HorizontalAlignment.Distributed;
            }
            return NPOI.SS.UserModel.HorizontalAlignment.General;
        }

        #endregion 设置列的对齐方式
    }
}