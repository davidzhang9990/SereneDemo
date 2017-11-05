using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171106002700)]
    public class DefaultDB_20171106_002700_PurchaseOrderDetail_Type : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("PurchaseOrderDetail")
                .AddColumn("IsFinishType").AsGuid().Nullable()
                .ForeignKey("FK_PurchaseOrderDetail_FinishTypeId", "ProductFinishType", "FinishTypeId");
        }
    }

}