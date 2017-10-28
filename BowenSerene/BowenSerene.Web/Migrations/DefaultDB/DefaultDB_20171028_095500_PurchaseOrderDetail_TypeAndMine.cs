using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171028095500)]
    public class DefaultDB_20171028_095500_PurchaseOrderDetail_TypeAndMine : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("PurchaseOrderDetail")
                .AddColumn("Category").AsString(100).Nullable()
                .AddColumn("Mine").AsString(100).Nullable()
                .AddColumn("Grade").AsString(100).Nullable();
        }
    }

}