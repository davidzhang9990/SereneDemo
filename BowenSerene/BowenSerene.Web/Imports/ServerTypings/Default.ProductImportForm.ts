namespace BowenSerene.Default {
    export class ProductImportForm extends Serenity.PrefixedContext {
        static formKey = 'Default.ProductImport';

    }

    export interface ProductImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    [['FileName', () => Serenity.ImageUploadEditor]].forEach(x => Object.defineProperty(ProductImportForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

