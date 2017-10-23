
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchaseOrderDetailDialog extends Serenity.EntityDialog<PurchaseOrderDetailRow, any> {
        protected getFormKey() { return PurchaseOrderDetailForm.formKey; }
        protected getIdProperty() { return PurchaseOrderDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderDetailRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseOrderDetailRow.nameProperty; }
        protected getService() { return PurchaseOrderDetailService.baseUrl; }

        protected form = new PurchaseOrderDetailForm(this.idPrefix);

    }
}