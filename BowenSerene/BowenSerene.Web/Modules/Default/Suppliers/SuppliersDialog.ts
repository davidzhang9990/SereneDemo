
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class SuppliersDialog extends Serenity.EntityDialog<SuppliersRow, any> {
        protected getFormKey() { return SuppliersForm.formKey; }
        protected getIdProperty() { return SuppliersRow.idProperty; }
        protected getLocalTextPrefix() { return SuppliersRow.localTextPrefix; }
        protected getNameProperty() { return SuppliersRow.nameProperty; }
        protected getService() { return SuppliersService.baseUrl; }

        protected form = new SuppliersForm(this.idPrefix);

    }
}