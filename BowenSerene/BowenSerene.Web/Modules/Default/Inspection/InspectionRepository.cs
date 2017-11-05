
using System.Linq;
using BowenSerene.Default.Entities;

namespace BowenSerene.Default.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.InspectionRow;

    public class InspectionRepository
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

        public DeleteResponse CustomDelete(IUnitOfWork uow, InspectionDeleteRequest request)
        {
            return new MyCustomDeleteHandler().Process(uow, request);
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
                    //只增加选中的明细
                    Row.OrderDetailsList = Row.OrderDetailsList.Where(x => x.IsAssign == 1).ToList();
                    foreach (var detail in Row.OrderDetailsList)
                    {
                        detail.ParentId = this.Row.InspectId;
                    }
                }
            }

            protected override void AfterSave()
            {
                base.AfterSave();
                if (Row.OrderDetailsList != null)
                {
                    var fld = PurchaseOrderDetailRow.Fields;
                    foreach (var detail in Row.OrderDetailsList)
                    {
                        if (detail.OrderDetailId.HasValue)
                        {
                            new SqlUpdate(fld.TableName)
                              .Where(fld.OrderDetailId == detail.OrderDetailId.Value)
                              .Set(fld.IsAssign, 1)
                              .Execute(this.UnitOfWork.Connection);
                        }
                    }
                }
            }
        }

        private class MyDeleteHandler : DeleteRequestHandler<MyRow>
        {
//            protected override void OnBeforeDelete()
//            {
//                base.OnBeforeDelete();
//                if (Row.InspectId.HasValue)
//                {
//                    var sqlCommond =
//                        "update PurchaseOrderDetail set IsAssign=0 where OrderDetailId in(select OrderDetailId from InspectionDetail where ParentId =" +
//                        Row.InspectId.Value + ")";
//
//                    this.UnitOfWork.Connection.Execute(sqlCommond);
//                }
//            }
        }

        private class MyCustomDeleteHandler : DeleteRequestHandler<MyRow, InspectionDeleteRequest, DeleteResponse>
        {
            protected override void OnAfterDelete()
            {
                base.OnAfterDelete();
                
                if (Request.InspectionDetails != null)
                {
                    var fld = PurchaseOrderDetailRow.Fields;
                    foreach (var detail in Request.InspectionDetails)
                    {
                        if (detail.OrderDetailId.HasValue)
                        {
                            new SqlUpdate(fld.TableName)
                              .Where(fld.OrderDetailId == detail.OrderDetailId.Value)
                              .Set(fld.IsAssign, 0)
                              .Execute(this.UnitOfWork.Connection);
                        }
                    }
                }
            }
        }
        //
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}