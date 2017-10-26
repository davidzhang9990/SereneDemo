using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171026165400)]
    public class DefaultDB_20171026_165400_PurchaseOrderDetail_Type : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("PurchaseOrderDetail")
                .AddColumn("IsFinishType").AsGuid().Nullable()
                .ForeignKey("FK_PurchaseOrderDetail_FinishTypeId", "ProductFinishType", "FinishTypeId");
        }
    }

}