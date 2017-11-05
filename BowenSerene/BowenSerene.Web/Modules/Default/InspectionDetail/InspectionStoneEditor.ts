/// <reference path="../../Common/Helpers/GridEditorBase.ts" />
/// <reference path="../../BasicSamples/Grids/CancellableBulkAction/OrderBulkAction.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class InspectionStoneEditor extends Common.GridEditorBase<InspectionDetailRow>{

        private rowSelection: Serenity.GridRowSelectionMixin;

        protected getColumnsKey() {
            return "Default.InspectionStone";
        }

        protected createToolbarExtensions() {
            super.createToolbarExtensions();
            this.rowSelection = new Serenity.GridRowSelectionMixin(this);
        }

        protected getLocalTextPrefix() {
            return InspectionDetailRow.localTextPrefix;
        }

        constructor(container: JQuery) {
            super(container);
            this.slickGrid.onSelectedRowsChanged.subscribe(
                (p1, selecion: { grid: Slick.Grid, rows: number[] }) => {
                    Q.log(selecion.rows[0]);
                    //this.EnableDisableControls(selecion.rows[0]);
                }
            );
        }

        protected getColumns() {
            var columns = super.getColumns();
            columns.splice(0, 0, Serenity.GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
            return columns;
        }

        protected getButtons() {
            return [
            {
                title: '明细确认',
                cssClass: 'send-button',
                onClick: () => {

                    Q.log(this.rowSelection.getSelectedKeys());
                    this.rowSelection.resetCheckedAndRefresh();

                    //                    if (!this.onViewSubmit()) {
                    //                        return;
                    //                    }
                    //                    var action = new BowenSerene.BasicSamples.OrderBulkAction();
                    //                    action.done = () => this.rowSelection.resetCheckedAndRefresh();
                    //                    action.execute(this.rowSelection.getSelectedKeys());
                }
            }];
        }

        //状态是已完成，关闭新增按钮
        //        protected updateInterface(): void {
        //           this.element.find('.add-button').hide();
        //            //this.toolbar.findButton('add-button').hide();
        //        }
    }
}