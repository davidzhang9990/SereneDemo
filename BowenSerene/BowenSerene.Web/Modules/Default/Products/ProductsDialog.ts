
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ProductsDialog extends Serenity.EntityDialog<ProductsRow, any> {
        protected getFormKey() { return ProductsForm.formKey; }
        protected getIdProperty() { return ProductsRow.idProperty; }
        protected getLocalTextPrefix() { return ProductsRow.localTextPrefix; }
        protected getNameProperty() { return ProductsRow.nameProperty; }
        protected getService() { return ProductsService.baseUrl; }

        protected form = new ProductsForm(this.idPrefix);

    }
}