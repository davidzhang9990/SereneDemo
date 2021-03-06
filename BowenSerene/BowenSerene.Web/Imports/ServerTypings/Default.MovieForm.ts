﻿namespace BowenSerene.Default {
    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Movie';

    }

    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        CastList: MovieCastEditor;
        Storyline: Serenity.TextAreaEditor;
        Year: Serenity.IntegerEditor;
        PrimaryImage: Serenity.ImageUploadEditor;
        GalleryImages: Serenity.MultipleImageUploadEditor;
        ReleaseDate: Serenity.DateEditor;
        Kind: Serenity.EnumEditor;
        GenreList: Serenity.LookupEditor;
        Runtime: Serenity.IntegerEditor;
    }

    [['Title', () => Serenity.StringEditor], ['Description', () => Serenity.TextAreaEditor], ['CastList', () => MovieCastEditor], ['Storyline', () => Serenity.TextAreaEditor], ['Year', () => Serenity.IntegerEditor], ['PrimaryImage', () => Serenity.ImageUploadEditor], ['GalleryImages', () => Serenity.MultipleImageUploadEditor], ['ReleaseDate', () => Serenity.DateEditor], ['Kind', () => Serenity.EnumEditor], ['GenreList', () => Serenity.LookupEditor], ['Runtime', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(MovieForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

