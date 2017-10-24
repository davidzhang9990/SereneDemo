namespace BowenSerene.Default {
    export class ProductsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Products';

    }

    export interface ProductsForm {
        Number: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Density: Serenity.DecimalEditor;
        Place: Serenity.StringEditor;
        IsActive: Serenity.EnumEditor;
        Attach: Serenity.MultipleImageUploadEditor;
    }

    [['Number', () => Serenity.StringEditor], ['Name', () => Serenity.StringEditor], ['Density', () => Serenity.DecimalEditor], ['Place', () => Serenity.StringEditor], ['IsActive', () => Serenity.EnumEditor], ['Attach', () => Serenity.MultipleImageUploadEditor]].forEach(x => Object.defineProperty(ProductsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

