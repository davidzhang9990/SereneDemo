using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171021130000)]
    public class DefaultDB_20171021_130000_Movie : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Movie", "MovieId", s => s
                .WithColumn("Title").AsString(200).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("Storyline").AsString(int.MaxValue).Nullable()
                .WithColumn("Year").AsInt32().Nullable()
                .WithColumn("ReleaseDate").AsDateTime().Nullable()
                .WithColumn("Runtime").AsInt32().Nullable());
        }
    }
}