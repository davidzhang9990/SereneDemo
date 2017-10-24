/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class PurchaseOrderDetailEditDialog extends Common.GridEditorDialog<PurchaseOrderDetailRow> { 
        protected getFormKey() { return PurchaseOrderDetailForm.formKey; }
        protected getNameProperty() { return PurchaseOrderDetailRow.nameProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderDetailRow.localTextPrefix; }

        protected form: PurchaseOrderDetailForm;

        constructor() {
            super();
            this.form = new PurchaseOrderDetailForm(this.idPrefix);
        }
    }
}