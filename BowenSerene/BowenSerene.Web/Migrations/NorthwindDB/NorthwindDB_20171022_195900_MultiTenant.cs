using FluentMigrator;

namespace BowenSerene.Migrations.NorthwindDB
{
    [Migration(20171022195900)]
    public class NorthwindDB_20171022_195900_MultiTenant : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Employees")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
            Alter.Table("Categories")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
            Alter.Table("Customers")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
            Alter.Table("Shippers")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
            Alter.Table("Suppliers")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
            Alter.Table("Orders")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
            Alter.Table("Products")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
            Alter.Table("Region")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
            Alter.Table("Territories")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
        }
    }
}