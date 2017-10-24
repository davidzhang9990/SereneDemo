namespace BowenSerene.Default {
    export class SuppliersForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Suppliers';

    }

    export interface SuppliersForm {
        Number: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Country: Serenity.StringEditor;
        Suffix: Serenity.StringEditor;
        Place: Serenity.StringEditor;
        Notes: Serenity.StringEditor;
        IsActive: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
    }

    [['Number', () => Serenity.StringEditor], ['Name', () => Serenity.StringEditor], ['Country', () => Serenity.StringEditor], ['Suffix', () => Serenity.StringEditor], ['Place', () => Serenity.StringEditor], ['Notes', () => Serenity.StringEditor], ['IsActive', () => Serenity.IntegerEditor], ['InsertDate', () => Serenity.DateEditor], ['InsertUserId', () => Serenity.IntegerEditor], ['UpdateDate', () => Serenity.DateEditor], ['UpdateUserId', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(SuppliersForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

