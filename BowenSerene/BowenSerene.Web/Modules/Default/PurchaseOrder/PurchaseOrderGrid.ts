
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class PurchaseOrderGrid extends Serenity.EntityGrid<PurchaseOrderRow, any> {
        protected getColumnsKey() { return 'Default.PurchaseOrder'; }
        protected getDialogType() { return PurchaseOrderDialog; }
        protected getIdProperty() { return PurchaseOrderRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderRow.localTextPrefix; }
        protected getService() { return PurchaseOrderService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        //打开窗体
        private openOrderDialog(orderType:number) {
            var dlg = new PurchaseOrderDialog();
            this.initDialog(dlg);
            // get a reference to product Chai
            //                    var chai = Northwind.ProductRow.getLookup().items
            //                        .filter(x => x.ProductName === 'Chai')[0];

            // LoadEntityAndOpenDialog, loads an OrderRow 
            // to dialog and opens it
            //                    var lauraCallahanID = Northwind.EmployeeRow.getLookup().items
            //                        .filter(x => x.FullName === 'Laura Callahan')[0].EmployeeID;

            dlg.loadEntityAndOpenDialog(<PurchaseOrderRow>{
                Type: orderType
            });
        }
        //david 设置页面按钮
        protected getButtons() {
            // preserving default New Item button
            var buttons = super.getButtons();
            //删除默认添加按钮
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
            buttons.push({
                title: '新增荒料',
                cssClass: 'add-button',
                onClick: () => {
                    this.openOrderDialog(Default.PurchaseType.Stone);
                }
            });
            buttons.push({
                title: '新增板材',
                cssClass: 'add-button',
                onClick: () => {
                    this.openOrderDialog(Default.PurchaseType.Slab);
                }
            });
            return buttons;
        }
    }
}