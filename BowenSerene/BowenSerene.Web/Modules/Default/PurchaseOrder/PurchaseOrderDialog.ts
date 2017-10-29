
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

        constructor(ordertype: string) {
            super();
            this.form.OrderDetailsList.orderType = ordertype;
            Q.log("dialog Id：" + ordertype);
            //供应商改变事件
            this.form.SupplierId.changeSelect2(e => {
                this.supplierChange();
            });
        }

        private supplierChange() {
            var supplierId = Q.toId(this.form.SupplierId.value);
            var place = Q.first(Default.SuppliersRow.getLookup().items, x => x.SupplierId == supplierId).Place;
            this.form.OrderDetailsList.place = place;
        }
        private setProducts() {
            var supplierId = Q.toId(this.form.SupplierId.value);
            var place = Q.first(Default.SuppliersRow.getLookup().items, x => x.SupplierId == supplierId).Place;
            this.form.OrderDetailsList.place = place;
            //            this.form.OrderStoneList.customProductList = [];
            //            if (Q.isEmptyOrNull(supplierId)) {
            //                return;
            //            }
            //            Default.ProductsService.ListProductsBySupplier({
            //                SupplierId: supplierId
            //            }, response => {
            //                this.form.OrderStoneList.customProductList = response.Entities;
            //                this.form.OrderStoneList.clearView();
            //            });
        }

        //#david 加载实体完成事件
        loadEntity(entity: PurchaseOrderRow) {
            console.log("load data...");
            super.loadEntity(entity);
            var orderType = this.form.Type.value;
            //默认为 stone 类型
            if (Q.isEmptyOrNull(orderType)) {
                this.form.Type.value = Default.PurchaseType.Stone.toString();
            }

            var supplierId = Q.toId(this.form.SupplierId.value);
            if (supplierId != null) {
                this.supplierChange();
            }
            //设置明细窗体的 type
            //this.form.OrderDetailsList.orderType =this.form.Type.value;
            // this.form.OrderDetailsList.getGrid();
            var columns = this.form.OrderDetailsList.getGrid().getColumns().filter(function (x) { return x.name === "厚度" });
            columns[0].visible = false;

            //this.form.OrderDetailsList ;
            if (this.form.Type.value === Default.PurchaseType.Stone.toString()) {
                this.byId('ShareType').closest('.field').show();
                //this.byId('OrderSlabList').closest('.field').show();
            } else {
                this.byId('ShareType').closest('.field').hide();
                // this.byId('OrderStoneList').closest('.field').show();
                //this.form.OrderStoneList.getGridField().toggle(false);
            }
            //            Serenity.TabsExtensions.setDisabled(this.tabs, 'Customer',
            //                !this.getCustomerID());
        }
    }
}