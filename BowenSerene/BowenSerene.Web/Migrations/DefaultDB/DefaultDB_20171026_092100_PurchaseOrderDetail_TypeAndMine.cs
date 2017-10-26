using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171026092100)]
    public class DefaultDB_20171026_092100_PurchaseOrderDetail_TypeAndMine : AutoReversingMigration
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