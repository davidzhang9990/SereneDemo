
namespace BowenSerene.Default
{
    using BowenSerene.Default.Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("Default.Products")]
    public sealed class ProductsLookup : RowLookupScript<ProductsRow>
    {
        public ProductsLookup()
        {
            IdField = ProductsRow.Fields.ProductId.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            query.Select(ProductsRow.Fields.ProductId);
            query.Select(ProductsRow.Fields.Name);
            query.Select(ProductsRow.Fields.Place);
            query.Select(ProductsRow.Fields.Density);
        }
    }
}