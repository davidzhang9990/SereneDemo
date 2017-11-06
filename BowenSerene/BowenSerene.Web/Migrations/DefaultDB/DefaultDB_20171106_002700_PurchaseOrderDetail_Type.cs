using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171106002700)]
    public class DefaultDB_20171106_002700_PurchaseOrderDetail_Type : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("ProductFinishType", "FinishTypeId", s => s
              .WithColumn("Name").AsString(100).NotNullable()
               .WithColumn("SortCode").AsInt32().Nullable().WithDefaultValue(0)
               .WithColumn("IsActive").AsInt16().NotNullable()
               .WithColumn("InsertDate").AsDateTime().Nullable()
               .WithColumn("InsertUserId").AsInt32().Nullable()
               .WithColumn("UpdateDate").AsDateTime().Nullable()
               .WithColumn("UpdateUserId").AsInt32().Nullable());
        }
    }

}