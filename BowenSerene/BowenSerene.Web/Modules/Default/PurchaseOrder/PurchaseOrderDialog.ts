
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
        private supplierId: string;
        public type: string;

        constructor() {
            super();
            //供应商改变事件
            this.form.SupplierId.changeSelect2(e => {
                var supplierId = Q.toId(this.form.SupplierId.value);

                if (Q.isEmptyOrNull(supplierId)) {
                    return;
                }

                this.form.OrderStoneList.supplierId = supplierId;
                //var place = Q.first(Default.SuppliersRow.getLookup().items, x => x.SupplierId == supplierId).Place;

//                Default.SuppliersService.Retrieve({
//                    EntityId: supplierId
//                }, response => {
//                    this.form.OrderStoneList.supplierId = response.Entity.Place;
//                });
            });
        }

        //#david 加载实体完成事件
        loadEntity(entity: Northwind.OrderRow) {
            super.loadEntity(entity);
            var orderType = this.form.Type.value;
            if (Q.isEmptyOrNull(orderType)) {
                this.form.Type.value = Default.PurchaseType.Stone.toString();
            }
            //设置明细窗体的 type
            //this.form.OrderStoneList.orderType = this.form.Type.value;
            //荒料 Q.isEmptyOrNull(orderType)
            if (this.form.Type.value === Default.PurchaseType.Stone.toString()) {
                this.byId('ShareType').closest('.field').show();
                //this.byId('OrderSlabList').closest('.field').show();
                this.form.OrderSlabList.getGridField().toggle(false);
            } else {
                this.byId('ShareType').closest('.field').hide();
               // this.byId('OrderStoneList').closest('.field').show();
                this.form.OrderStoneList.getGridField().toggle(false);
            }
            //            Serenity.TabsExtensions.setDisabled(this.tabs, 'Customer',
            //                !this.getCustomerID());
        }
    }
}