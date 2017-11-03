
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class PurchaseOrderStoneDialog extends Serenity.EntityDialog<PurchaseOrderRow, any> {

        protected getFormKey() { return PurchaseOrderStoneForm.formKey; }
        protected getIdProperty() { return PurchaseOrderRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseOrderRow.nameProperty; }
        protected getService() { return PurchaseOrderService.baseUrl; }

        protected form: PurchaseOrderStoneForm;

        constructor() {
            super();
            this.form = new PurchaseOrderStoneForm(this.idPrefix);
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

        //状态是已完成，关闭新增按钮
        protected updateInterface(): void {
            this.form.Type.value = Default.PurchaseType.Stone.toString();
            if (this.entity.Status === 1) {
                this.element.find('.add-button').hide();
            }
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