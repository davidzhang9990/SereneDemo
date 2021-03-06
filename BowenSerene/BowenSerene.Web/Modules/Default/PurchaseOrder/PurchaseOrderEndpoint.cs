﻿
namespace BowenSerene.Default.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using System;
    using Serenity.Util.Offices;
    using Serenity.Web;

    using MyRepository = Repositories.PurchaseOrderRepository;
    using MyRow = Entities.PurchaseOrderRow;

    [RoutePrefix("Services/Default/PurchaseOrder"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class PurchaseOrderController : ServiceEndpoint
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
        public ListResponse<MyRow> List(IDbConnection connection, PurchaseOrderListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public FileContentResult ListExcel(ExcelDownRequest request)
        {
            var templateName = "HLPurchaseOrder.xlsx";
            var templateFileName = "ProductList_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
            var dataJson = request.ProductsList.Split(',');
//            ExcelHelper.ExcelCustomDownload(dataJson, 30, templateName, templateFileName, "0");

            //执行导出
            var bytes = ExcelHelper.ExportListByTempale(dataJson, 30, templateName, "0");
            return ExcelContentResult.Create(bytes.ToArray(), templateFileName);
        }
    }
}
