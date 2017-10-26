namespace BowenSerene.Default {
    export class ProductFinishTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Default.ProductFinishType';

    }

    export interface ProductFinishTypeForm {
        Name: Serenity.StringEditor;
        IsActive: Serenity.EnumEditor;
    }

    [['Name', () => Serenity.StringEditor], ['IsActive', () => Serenity.EnumEditor]].forEach(x => Object.defineProperty(ProductFinishTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

