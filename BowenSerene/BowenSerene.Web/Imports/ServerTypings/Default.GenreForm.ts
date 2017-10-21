namespace BowenSerene.Default {
    export class GenreForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Genre';

    }

    export interface GenreForm {
        Name: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
    }

    [['Name', () => Serenity.StringEditor], ['CreateDate', () => Serenity.DateEditor]].forEach(x => Object.defineProperty(GenreForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

