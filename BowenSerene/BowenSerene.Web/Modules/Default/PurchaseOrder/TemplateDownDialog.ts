namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class TemplateDownDialog extends Serenity.PropertyDialog<any, any> {

        private form: TemplateDownDialogForm;

        constructor() {
            super();

            this.form = new TemplateDownDialogForm(this.idPrefix);
        }

        protected getDialogTitle(): string {
            return "导出Excel模板";
        }

        protected getDialogButtons(): Serenity.DialogButton[] {
            return [
                {
                    text: '下载模板',
                    click: () => {
                        if (!this.validateBeforeSave())
                            return;

                        if (this.form.SupplierId.value == null ||
                            Q.isEmptyOrNull(this.form.SupplierId.value)) {
                            Q.notifyError("请选择供应商!");
                            return;
                        }
                        var supplierId = this.form.SupplierId.value;
                        var place = Q.first(Default.SuppliersRow.getLookup().items, x => x.SupplierId == supplierId).Place;
                        var itemJson = ProductsRow.getLookup().items.filter(x => x.Place == place);
                        var json = "";
                        for (var c of itemJson) {
                            if (json.length === 0) {
                                json += Q.htmlEncode(c.Name);
                            } else {
                                json += "," + Q.htmlEncode(c.Name);
                            }
                        }

                        //                        if (!options.onViewSubmit()) {
                        //                            return;
                        //                        }
                        //
                        //                        let grid = options.grid;
                        //
                        //                        var request = Q.deepClone(grid.getView().params) as Serenity.ListRequest;
                        //                        request.Take = 0;
                        //                        request.Skip = 0;
                        //                        var sortBy = grid.getView().sortBy;
                        //                        if (sortBy) {
                        //                            request.Sort = sortBy;
                        //                        }
                        //
                        //                        request.IncludeColumns = [];
                        //                        let columns = grid.getGrid().getColumns();
                        //                        for (let column of columns) {
                        //                            request.IncludeColumns.push(column.id || column.field);
                        //                        }

                        Q.postToService({ service: "Default/PurchaseOrder/ListExcel", request: { ProductsList: json }, target: '_blank' });
                        this.dialogClose();
                        
//                        PurchaseOrderService.ListExcel({
//                            ProductsList: json
//                        }, response => {
//                            Q.log(response);
//                            Q.notifyInfo(response.ContentResult);
//                            this.dialogClose();
//                        });
                    },
                },
                {
                    text: '关闭',
                    click: () => this.dialogClose()
                }
            ];
        }
    }
}