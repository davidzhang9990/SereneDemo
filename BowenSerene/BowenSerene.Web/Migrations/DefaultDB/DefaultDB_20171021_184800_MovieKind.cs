using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171021184800)]
    public class DefaultDB_20171021_184800_MovieKind : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Movie").AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
        }
    }
}