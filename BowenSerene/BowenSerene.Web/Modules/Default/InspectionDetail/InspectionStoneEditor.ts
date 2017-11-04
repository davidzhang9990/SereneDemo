/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class InspectionStoneEditor extends Common.GridEditorBase<InspectionDetailRow>{

        protected getColumnsKey() { return "Default.InspectionStone"; }
        protected getLocalTextPrefix() { return InspectionDetailRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}