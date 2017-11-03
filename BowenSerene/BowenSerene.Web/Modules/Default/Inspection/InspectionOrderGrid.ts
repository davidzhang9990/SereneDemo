/// <reference path="../PurchaseOrder/PurchaseOrderGrid.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class InspectionOrderGrid extends Default.PurchaseOrderGrid {

        protected getDialogType() { return PurchaseOrderStoneDialog; }

        constructor(container: JQuery) {
            super(container);
            Q.log("customer grid..");
        }
    }
}