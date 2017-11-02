
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class PurchaseOrderGrid extends Serenity.EntityGrid<PurchaseOrderRow, any> {


        protected getColumnsKey() { return 'Default.PurchaseOrder'; }
        protected getIdProperty() { return PurchaseOrderRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderRow.localTextPrefix; }
        protected getService() { return PurchaseOrderService.baseUrl; }

        //        protected getDialogType() { return PurchaseOrderDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns(): Slick.Column[] {
            var columns = super.getColumns();

            var fld = PurchaseOrderRow.Fields;

            Q.first(columns, x => x.field == fld.Number).format =
                ctx => `<a href="javascript:;" class="customer-link">${Q.htmlEncode(ctx.value)}</a>`;

            return columns;
        }

        //david 设置页面按钮
        protected getButtons() {
            // preserving default New Item button
            var buttons = super.getButtons();
            //删除默认添加按钮
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
            buttons.push({
                title: '导出Excel模板',
                cssClass: 'export-xlsx-button',
                onClick: () => {
                    // open import dialog, let it handle rest
                    var dialog = new TemplateDownDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });
            buttons.push({
                title: '新增荒料',
                cssClass: 'add-button',
                onClick: () => {
                    var dlg = new PurchaseOrderStoneDialog();
                    this.initDialog(dlg);
                    dlg.loadEntityAndOpenDialog(<PurchaseOrderRow>{
                        Type: Default.PurchaseType.Stone
                    });
                }
            });
            buttons.push({
                title: '新增板材',
                cssClass: 'add-button',
                onClick: () => {
                    var dlg = new PurchaseOrderSlabDialog();
                    this.initDialog(dlg);
                    dlg.loadEntityAndOpenDialog(<PurchaseOrderRow>{
                        Type: Default.PurchaseType.Slab
                    });
                }
            });
            return buttons;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number): void {

            // let base grid handle clicks for its edit links
            super.onClick(e, row, cell);

            // if base grid already handled, we shouldn"t handle it again
            if (e.isDefaultPrevented()) {
                return;
            }
            // get reference to current item
            var item = this.itemAt(row);

            // get reference to clicked element
            var target = $(e.target);

            if (target.hasClass("customer-link")) {
                e.preventDefault();

                if (item.Type == 0) {
                    new Default.PurchaseOrderStoneDialog().loadByIdAndOpenDialog(item.PurchaseOrderId);
                } else {
                    new Default.PurchaseOrderSlabDialog().loadByIdAndOpenDialog(item.PurchaseOrderId);
                }
            }
        }
    }
}