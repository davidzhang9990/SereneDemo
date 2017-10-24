using System;
using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171024101100)]
    public class DefaultDB_20171024_101100_ProductAndSupplier : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Products")
                .WithColumn("ProductId").AsGuid().PrimaryKey().WithDefaultValue(Guid.NewGuid()).NotNullable()
                .WithColumn("Number").AsString(100).NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Density").AsDecimal().NotNullable()
                .WithColumn("Place").AsString(100).NotNullable()
                .WithColumn("Attach").AsString(1000).Nullable()
                 .WithColumn("IsActive").AsInt16().NotNullable()
                 .WithColumn("InsertDate").AsDateTime().Nullable()
                 .WithColumn("InsertUserId").AsInt32().Nullable()
                 .WithColumn("UpdateDate").AsDateTime().Nullable()
                 .WithColumn("UpdateUserId").AsInt32().Nullable();


            Create.Table("Suppliers")
                .WithColumn("SupplierId").AsGuid().PrimaryKey().WithDefaultValue(Guid.NewGuid()).NotNullable()
                .WithColumn("Number").AsString(100).NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                 .WithColumn("Country").AsString(100).NotNullable()
                 .WithColumn("Suffix").AsString(100).Nullable()
                .WithColumn("Place").AsString(100).NotNullable()
                .WithColumn("Notes").AsString(1000).Nullable()
                 .WithColumn("IsActive").AsInt16().NotNullable()
                 .WithColumn("InsertDate").AsDateTime().Nullable()
                 .WithColumn("InsertUserId").AsInt32().Nullable()
                 .WithColumn("UpdateDate").AsDateTime().Nullable()
                 .WithColumn("UpdateUserId").AsInt32().Nullable();
        }
    }

}