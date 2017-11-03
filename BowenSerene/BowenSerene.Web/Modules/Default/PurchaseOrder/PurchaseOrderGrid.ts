
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class PurchaseOrderGrid extends Serenity.EntityGrid<PurchaseOrderRow, any> {


        protected getColumnsKey() { return 'Default.PurchaseOrder'; }
        protected getIdProperty() { return PurchaseOrderRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderRow.localTextPrefix; }
        protected getService() { return PurchaseOrderService.baseUrl; }

        protected getDialogType() { return PurchaseOrderStoneDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickFilters() {
            var filters = super.getQuickFilters();
            let fld = Default.PurchaseOrderDetailRow.Fields;

            filters.push({
                type: Serenity.LookupEditor,
                options: {
                    lookupKey: ProductsRow.lookupKey
                },
                field: 'ProductID',
                title: '品目',
                handler: w => {
                    (this.view.params as PurchaseOrderListRequest).ProductId = Q.toId(w.value);
                }
            });

            //            Q.first(filters, x => x.field == fld.Container).init = w => {
            //                // enum editor has a string value, so need to call toString()
            //                (w as Serenity.EnumEditor).value = Northwind.OrderShippingState.NotShipped.toString()
            //            };

            //            Q.first(filters, x => x.field == fld.Container).init = w => {
            //                // enum editor has a string value, so need to call toString()
            //                (w as Serenity.EnumEditor).value = Northwind.OrderShippingState.NotShipped.toString()
            //            };

            filters.push({
                type: Serenity.StringEditor,
                field: 'Container',
                title: '货柜号',
                handler: w => {
                    (this.view.params as PurchaseOrderListRequest).Container = Q.toId(w.value);
                }
            });
            return filters;
        }

        //        protected createQuickFilters(): void {
        //
        //            // let base class to create quick filters first
        //            super.createQuickFilters();
        //
        //            // get a reference to order row field names
        //            let fld = Default.PurchaseOrderDetailRow.Fields;
        //
        //            // find a quick filter widget by its field name
        //            this.findQuickFilter(Serenity.LookupEditor, fld.IsAssign).values = ["0", "1"];
        //        }
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
                        Type: Default.PurchaseType.Slab,
                        ShareType: Default.PurchaseShareType.VolumeShare
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
                    var stonedlg = new PurchaseOrderStoneDialog();
                    this.initDialog(stonedlg);
                    stonedlg.loadByIdAndOpenDialog(item.PurchaseOrderId);
                } else {
                    var slabdlg = new PurchaseOrderSlabDialog();
                    this.initDialog(slabdlg);
                    slabdlg.loadByIdAndOpenDialog(item.PurchaseOrderId);
                }
            }
        }
    }
}