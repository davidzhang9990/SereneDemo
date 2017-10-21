using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171021221100)]
    public class DefaultDB_20171021_221100_PersonAndMovieCast : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Person", "PersonId", s => s
                  .WithColumn("Firstname").AsString(50).NotNullable()
                   .WithColumn("Lastname").AsString(50).NotNullable()
                   .WithColumn("BirthDate").AsDateTime().Nullable()
                   .WithColumn("BirthPlace").AsString(100).Nullable()
                   .WithColumn("Gender").AsInt32().Nullable()
                   .WithColumn("Height").AsInt32().Nullable());

            this.CreateTableWithId32("MovieCast", "MovieCastId", s => s
                  .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_MovieId", "Movie", "MovieId")
                .WithColumn("PersonId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_PersonId", "Person", "PersonId")
                .WithColumn("Character").AsString(50).Nullable());
        }
    }

}