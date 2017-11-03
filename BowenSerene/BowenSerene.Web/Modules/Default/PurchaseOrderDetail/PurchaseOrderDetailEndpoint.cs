
using System;
using System.Collections.Generic;
using System.IO;
using BowenSerene.Default.Entities;
using OfficeOpenXml;
using Serenity.Web;

namespace BowenSerene.Default.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.PurchaseOrderDetailRepository;
    using MyRow = Entities.PurchaseOrderDetailRow;

    [RoutePrefix("Services/Default/PurchaseOrderDetail"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class PurchaseOrderDetailController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        [HttpPost]
        public ProductsImportResponse<MyRow> ExcelImport(IUnitOfWork uow, ExcelImportRequest request)
        {
            request.CheckNotNull();
            Check.NotNullOrWhiteSpace(request.FileName, "filename");

            UploadHelper.CheckFileNameSecurity(request.FileName);

            if (!request.FileName.StartsWith("temporary/"))
                throw new ArgumentOutOfRangeException("filename");

            ExcelPackage ep = new ExcelPackage();
            using (var fs = new FileStream(UploadHelper.DbFilePath(request.FileName), FileMode.Open, FileAccess.Read))
                ep.Load(fs);

            var p = ProductsRow.Fields;
            var response = new ProductsImportResponse<MyRow>();
            response.Entities=new List<PurchaseOrderDetailRow>();

           var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var inserRow = new PurchaseOrderDetailRow();
                    var productName = Convert.ToString(worksheet.Cells[row, 1].Value ?? "");
                    if (productName.IsTrimmedEmpty())
                        continue;

                    var product = uow.Connection.TryFirst<ProductsRow>(q => q
                        .Select(p.ProductId)
                        .Where(p.Name == productName));

                    if (product == null)
                    {
                        continue;
                    }

                    inserRow.ProductId = product.ProductId;
                    inserRow.ProductName = productName;
                    inserRow.Category = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    inserRow.Container = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    inserRow.BlockNumber = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    inserRow.Length = Convert.ToInt16(worksheet.Cells[row, 5].Value ?? 0);
                    inserRow.Width = Convert.ToInt16(worksheet.Cells[row, 6].Value ?? 0);
                    inserRow.Height = Convert.ToInt16(worksheet.Cells[row, 7].Value ?? 0);
                    inserRow.Volume = Convert.ToDecimal(worksheet.Cells[row, 8].Value ?? 0);
                    inserRow.Weight = Convert.ToDecimal(worksheet.Cells[row, 9].Value ?? 0);
                    inserRow.Grade = Convert.ToString(worksheet.Cells[row, 10].Value ?? "");
                    inserRow.Mine = Convert.ToString(worksheet.Cells[row, 11].Value ?? "");
                    response.Entities.Add(inserRow);

                    response.TotalCount= response.TotalCount + 1;

                    //                    var supplier = uow.Connection.TryFirst<SupplierRow>(q => q
                    //                           .Select(s.SupplierID)
                    //                           .Where(s.CompanyName == supplierName));
                    //
                    //                    if (supplier == null)
                    //                    {
                    //                        response.ErrorList.Add("Error On Row " + row + ": Supplier with name '" +
                    //                            supplierName + "' is not found!");
                    //                        continue;
                    //                    }

                }
                catch (Exception ex)
                {
                    response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                }
            }

            return response;
        }
    }
}
