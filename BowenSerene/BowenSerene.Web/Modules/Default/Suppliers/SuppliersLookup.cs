
namespace BowenSerene.Default
{
    using BowenSerene.Default.Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("Default.Suppliers")]
    public sealed class SuppliersLookup : RowLookupScript<SuppliersRow>
    {
        public SuppliersLookup()
        {
            IdField = SuppliersRow.Fields.SupplierId.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            query.Select(SuppliersRow.Fields.SupplierId);
            query.Select(SuppliersRow.Fields.Name);
            query.Select(SuppliersRow.Fields.Place);
        }
    }
}