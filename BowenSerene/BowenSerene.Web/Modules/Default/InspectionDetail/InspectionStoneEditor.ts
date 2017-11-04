/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

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
        }

        protected getColumns() {
            var columns = super.getColumns();
            columns.splice(0, 0, Serenity.GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
            return columns;
        }

        protected getButtons() {
            return [
                {
                    title: '新增',
                    cssClass: 'add-button',
                    onClick: () => {
                        Q.log("test hide");
                    }
                }
            ];
        }

        //状态是已完成，关闭新增按钮
//        protected updateInterface(): void {
//           this.element.find('.add-button').hide();
//            //this.toolbar.findButton('add-button').hide();
//        }
    }
}