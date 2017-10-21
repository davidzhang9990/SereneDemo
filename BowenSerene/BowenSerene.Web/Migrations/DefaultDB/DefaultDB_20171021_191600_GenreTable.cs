using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171021191600)]
    public class DefaultDB_20171021_191600_GenreTable : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Genre", "GenreId", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("CreateDate").AsDateTime().Nullable());

            Alter.Table("Movie").AddColumn("GenreId").AsInt32().Nullable()
             .ForeignKey("FK_Movie_GenreId", "Genre", "GenreId");
        }
    }
}