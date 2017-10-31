﻿
namespace BowenSerene.Default.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.PurchaseOrderRow;

    public class PurchaseOrderRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow>
        {
            protected override void BeforeSave()
            {
                base.BeforeSave();

                if (Row.OrderDetailsList != null)
                {
                    foreach (var detail in Row.OrderDetailsList)
                    {
                        detail.ParentId = this.Row.PurchaseOrderId.Value;
                    }
                }
                Console.Write(Row);
            }

            protected override void AfterSave()
            {
                base.AfterSave();
//                if (Row.OrderStoneList != null)
//                {
//                    var mc = Entities.PurchaseOrderDetailRow.Fields;
//                    var oldList = IsCreate ? null : Connection.List<Entities.PurchaseOrderDetailRow>(mc.ParentId == this.Row.PurchaseOrderId.Value);
//
//                    new Common.DetailListSaveHandler<Entities.PurchaseOrderDetailRow>(oldList, Row.OrderStoneList,
//                              x => x.ParentId = Row.PurchaseOrderId.Value).Process(this.UnitOfWork);
//                }
            }
            protected override void SetInternalFields()
            {
                base.SetInternalFields();

                if (IsCreate)
                {
                    Row.PurchaseOrderId = Guid.NewGuid();
                    Row.Status = 0;
                }
            }
        }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }

        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow>
        {
            protected override void OnReturn()
            {
                base.OnReturn();
//                var mc = Entities.PurchaseOrderDetailRow.Fields;
//                Row.OrderStoneList = Connection.List<Entities.PurchaseOrderDetailRow>(q => q
//                    .SelectTableFields()
//                    .Where(mc.ParentId == Row.PurchaseOrderId.Value));
            }
        }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}