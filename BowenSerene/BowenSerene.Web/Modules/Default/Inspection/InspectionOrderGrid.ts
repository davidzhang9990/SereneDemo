/// <reference path="../PurchaseOrder/PurchaseOrderGrid.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class InspectionOrderGrid extends Default.PurchaseOrderGrid {

        protected getDialogType() { return PurchaseOrderStoneDialog; }

        constructor(container: JQuery) {
            super(container);
            Q.log("customer grid..");
        }

        protected getQuickFilters() {
            var filters = super.getQuickFilters();

            filters.push({
                type: Serenity.BooleanEditor,
                field: 'IsAssign',
                title: '指派',
                handler: w => {
                    w.active = !!w.value;
                    let status = 0;
                    if (w.active) {
                        status = 1;
                    }
                    (this.view.params as PurchaseOrderListRequest).IsAssign = status;
                }
            });

            return filters;
        }
    }
}