/// <reference path="../../Common/Helpers/GridEditorBase.ts" />
/// <reference path="../../BasicSamples/Grids/CancellableBulkAction/OrderBulkAction.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class InspectionStoneEditor extends Common.GridEditorBase<InspectionDetailRow>{

        public rowSelection: Serenity.GridRowSelectionMixin;

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
        }

        protected getColumns() {
            var columns = super.getColumns();
            columns.splice(0, 0, Serenity.GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
            return columns;
        }

        protected getIdProperty() { return "__id"; }

        //保存前设置选中的行 IsAssign=1
        public setViewDataSelect() {
            var items = this.view.getItems().slice();
            var selectItems = this.rowSelection.getSelectedKeys();
            for (var p of items) {
                let id = (p as any)[this.getIdProperty()];
                if (selectItems.indexOf(id) > -1) {
                    p.IsAssign = 1;
                }
            }
            //set entitys
            this.setEntities(items);
        }

        protected getButtons() {
            return [];
        }

        //状态是已完成，关闭新增按钮
//        protected updateInterface(): void {
//            //this.element.find('.add-button').hide();
//            //this.toolbar.findButton('add-button').hide();
//        }
    }
}