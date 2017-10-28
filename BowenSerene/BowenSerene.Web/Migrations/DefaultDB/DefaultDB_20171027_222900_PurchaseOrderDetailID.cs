using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171027222900)]
    public class DefaultDB_20171027_222900_PurchaseOrderDetailID : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("PurchaseOrderDetail")
                .AddColumn("PurchaseOrderDetailId").AsGuid().PrimaryKey().NotNullable();
        }
    }

}