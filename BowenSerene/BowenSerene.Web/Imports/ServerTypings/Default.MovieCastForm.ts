namespace BowenSerene.Default {
    export class MovieCastForm extends Serenity.PrefixedContext {
        static formKey = 'Default.MovieCast';

    }

    export interface MovieCastForm {
        MovieId: Serenity.IntegerEditor;
        PersonId: Serenity.IntegerEditor;
        Character: Serenity.StringEditor;
    }

    [['MovieId', () => Serenity.IntegerEditor], ['PersonId', () => Serenity.IntegerEditor], ['Character', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(MovieCastForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

