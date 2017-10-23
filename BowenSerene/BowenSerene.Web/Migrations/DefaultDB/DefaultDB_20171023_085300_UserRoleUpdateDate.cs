using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171023085300)]
    public class DefaultDB_20171023_085300_UserRoleUpdateDate : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Roles")
                 .AddColumn("InsertDate").AsDateTime().Nullable()
                 .AddColumn("InsertUserId").AsInt32().Nullable()
                 .AddColumn("UpdateDate").AsDateTime().Nullable()
                 .AddColumn("UpdateUserId").AsInt32().Nullable();
        }
    }

}