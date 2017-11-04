/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class InspectionStoneEditor extends Common.GridEditorBase<InspectionDetailRow>{

        protected getColumnsKey() {
             return "Default.InspectionStone";
        }

        protected getLocalTextPrefix() {
             return InspectionDetailRow.localTextPrefix;
        }

        constructor(container: JQuery) {
            super(container);
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