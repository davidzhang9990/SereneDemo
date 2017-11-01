﻿
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class PurchaseOrderStoneDialog extends Serenity.EntityDialog<PurchaseOrderRow, any> {
        protected getFormKey() { return PurchaseOrderStoneForm.formKey; }
        protected getIdProperty() { return PurchaseOrderRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseOrderRow.nameProperty; }
        protected getService() { return PurchaseOrderService.baseUrl; }

        protected form = new PurchaseOrderStoneForm(this.idPrefix);

        constructor() {
            super();
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

        //#david 加载实体完成事件
        loadEntity(entity: PurchaseOrderRow) {

            super.loadEntity(entity);
            var supplierId = Q.toId(this.form.SupplierId.value);
            if (supplierId != null) {
                this.supplierChange();
            }
        }
    }
}