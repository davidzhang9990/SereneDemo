
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class PurchaseOrderDetailGrid extends Serenity.EntityGrid<PurchaseOrderDetailRow, any> {
        protected getColumnsKey() { return 'Default.PurchaseOrderDetail'; }
        protected getDialogType() { return PurchaseOrderDetailDialog; }
        protected getIdProperty() { return PurchaseOrderDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderDetailRow.localTextPrefix; }
        protected getService() { return PurchaseOrderDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}