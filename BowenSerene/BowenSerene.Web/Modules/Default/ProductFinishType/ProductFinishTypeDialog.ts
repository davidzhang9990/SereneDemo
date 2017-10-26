
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ProductFinishTypeDialog extends Serenity.EntityDialog<ProductFinishTypeRow, any> {
        protected getFormKey() { return ProductFinishTypeForm.formKey; }
        protected getIdProperty() { return ProductFinishTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ProductFinishTypeRow.localTextPrefix; }
        protected getNameProperty() { return ProductFinishTypeRow.nameProperty; }
        protected getService() { return ProductFinishTypeService.baseUrl; }

        protected form = new ProductFinishTypeForm(this.idPrefix);

    }
}