﻿
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class PurchaseOrderDialog extends Serenity.EntityDialog<PurchaseOrderRow, any> {
        protected getFormKey() { return PurchaseOrderForm.formKey; }
        protected getIdProperty() { return PurchaseOrderRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseOrderRow.nameProperty; }
        protected getService() { return PurchaseOrderService.baseUrl; }

        protected form = new PurchaseOrderForm(this.idPrefix);

        constructor() {
            super();

            this.form.Type.changeSelect2(e => {
                var orderType = this.form.Type.value;
                this.byId('ShareType').closest('.field').hide();
                if (Q.isEmptyOrNull(orderType)) {
                    this.form.ShareType.clearItems();
                    return;
                }
                if (orderType === Default.PurchaseType.Stone.toString()) {
                    this.byId('ShareType').closest('.field').show();
                }
            });
        }

    }
}