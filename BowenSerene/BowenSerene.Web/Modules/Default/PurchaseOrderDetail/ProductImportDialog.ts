namespace BowenSerene.Default {
    import ListResponse = Serenity.ListResponse;

    @Serenity.Decorators.registerClass()
    export class ProductImportDialog extends Serenity.PropertyDialog<any, any> {

        private form: ProductImportForm;
        public orderDetails: ProductsImportResponse<PurchaseOrderDetailRow>;

        constructor() {
            super();
            this.form = new ProductImportForm(this.idPrefix);
        }

        protected getDialogTitle(): string {
            return "导入采购荒料数据";
        }

        protected getDialogButtons(): Serenity.DialogButton[] {
            return [
                {
                    text: '导入',
                    click: () => {
                        if (!this.validateBeforeSave())
                            return;

                        if (this.form.FileName.value == null ||
                            Q.isEmptyOrNull(this.form.FileName.value.Filename)) {
                            Q.notifyError("请选择文件!");
                            return;
                        }

                        PurchaseOrderDetailService.ExcelImport({
                            FileName: this.form.FileName.value.Filename
                        }, response => {
                            if (response.ErrorList != null && response.ErrorList.length > 0) {
                                Q.notifyError(response.ErrorList.join(',\r\n '));
                            } else {
                                this.orderDetails = response; 
                            }
                            
                            this.dialogClose();
                        });
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