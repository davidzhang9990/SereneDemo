using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171026145800)]
    public class DefaultDB_20171026_145800_ProductFinishType : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("ProductFinishType")
              .WithColumn("FinishTypeId").AsGuid().PrimaryKey().NotNullable()
              .WithColumn("Name").AsString(100).NotNullable()
              .WithColumn("SortCode").AsInt32().Nullable().WithDefaultValue(0)
              .WithColumn("IsActive").AsInt16().NotNullable()
              .WithColumn("InsertDate").AsDateTime().Nullable()
              .WithColumn("InsertUserId").AsInt32().Nullable()
              .WithColumn("UpdateDate").AsDateTime().Nullable()
              .WithColumn("UpdateUserId").AsInt32().Nullable();
        }
    }

}