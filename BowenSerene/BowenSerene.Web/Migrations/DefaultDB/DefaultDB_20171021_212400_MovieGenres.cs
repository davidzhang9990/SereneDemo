﻿using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171021212400)]
    public class DefaultDB_20171021_212400_MovieGenres : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("MovieGenres", "MovieGenreId", s => s
                 .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieGenres_MovieId", "Movie", "MovieId")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieGenres_GenreId", "Genre", "GenreId"));

            Execute.Sql(
              @"INSERT INTO MovieGenres (MovieId, GenreId) 
                    SELECT m.MovieId, m.GenreId 
                    FROM Movie m
                    WHERE m.GenreId IS NOT NULL");

            Delete.ForeignKey("FK_Movie_GenreId").OnTable("Movie");
            Delete.Column("GenreId").FromTable("Movie");

        }
    }
}