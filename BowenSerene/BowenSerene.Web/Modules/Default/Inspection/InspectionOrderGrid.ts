/// <reference path="../PurchaseOrder/PurchaseOrderGrid.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class InspectionOrderGrid extends Default.PurchaseOrderGrid {

        protected getDialogType() { return PurchaseOrderStoneDialog; }

        constructor(container: JQuery) {
            super(container);
            Q.log("customer grid..");
        }

        /**
         * This method is called just before List request is sent to service.
         * You have an opportunity here to cancel request or modify it.
         * Here we'll add a custom criteria to list request.
         */
        protected onViewSubmit() {
            if (!super.onViewSubmit()) {
                return false;
            }

            // this has no relation to our lookup editor but as we'll allow picking only 
            // categories of Produce and Seafood in product dialog, it's better to show
            // only products from these categories in grid too
            let request = this.view.params as PurchaseOrderListRequest;
            request.IsAssign = 0;
            // brackets used are important above, NOT ['CategoryName', 'in', ['Produce', 'Seafood']]

            return true;
        }

        //        protected getQuickFilters() {
        //            var filters = super.getQuickFilters();
        //
        //            filters.push({
        //                type: Serenity.BooleanEditor,
        //                field: 'IsAssign',
        //                title: '指派',
        //                handler: w => {
        //                    w.active = !!w.value;
        //                    let status = 0;
        //                    if (w.active) {
        //                        status = 1;
        //                    }
        //                    (this.view.params as PurchaseOrderListRequest).IsAssign = status;
        //                }
        //            });
        //
        //            return filters;
        //        }
    }
}