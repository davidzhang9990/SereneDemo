namespace BowenSerene.Default {
    export class SuppliersForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Suppliers';

    }

    export interface SuppliersForm {
        Number: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Suffix: Serenity.StringEditor;
        Country: Serenity.StringEditor;
        Place: Serenity.StringEditor;
        IsActive: Serenity.EnumEditor;
        Notes: Serenity.TextAreaEditor;
    }

    [['Number', () => Serenity.StringEditor], ['Name', () => Serenity.StringEditor], ['Suffix', () => Serenity.StringEditor], ['Country', () => Serenity.StringEditor], ['Place', () => Serenity.StringEditor], ['IsActive', () => Serenity.EnumEditor], ['Notes', () => Serenity.TextAreaEditor]].forEach(x => Object.defineProperty(SuppliersForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

