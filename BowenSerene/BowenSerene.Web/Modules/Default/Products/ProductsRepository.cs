
using System.Linq;
using BowenSerene.Default.Entities;
using BowenSerene.Northwind.Entities;

namespace BowenSerene.Default.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.ProductsRow;

    public class ProductsRepository
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

        public ListResponse<MyRow> ListProductsBySupplier(IDbConnection connection, ProductListRequest request)
        {
            Check.NotNull(request, "request");
            Check.NotNull(request.SupplierId, "supplierId");

            var pro = MyRow.Fields.As("pro");
            var sup = SuppliersRow.Fields.As("sup");

            var query = new SqlQuery()
                .From(pro)
                .Select(pro.ProductId)
                .Select(pro.Name)
                .Distinct(true)
                .OrderBy(pro.Name);

            query.Where(pro.Place.In(
                query.SubQuery()
                    .From(sup)
                    .Select(sup.Place)
                    .Where(sup.SupplierId == request.SupplierId)
            ));

            return new ListResponse<MyRow>
            {
                Entities = connection.Query<MyRow>(query).ToList()
            };
        }

        private class MySaveHandler : SaveRequestHandler<MyRow>
        {
            protected override void ValidateRequest()
            {
                base.ValidateRequest();
                if (IsCreate)
                {
                    //this.Row.Username = ValidateUsername(this.Connection, this.Row.Username, null);
                }
            }

            protected override void SetInternalFields()
            {
                base.SetInternalFields();

                if (IsCreate)
                {
                    Row.ProductId = Guid.NewGuid();
                }
            }
        }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}