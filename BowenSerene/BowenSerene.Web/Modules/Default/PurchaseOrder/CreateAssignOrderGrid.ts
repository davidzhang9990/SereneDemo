﻿
namespace BowenSerene.Default {
    import UserRow = BowenSerene.Administration.UserRow;

    @Serenity.Decorators.registerClass()
    export class CreateAssignOrderGrid extends Serenity.EntityGrid<PurchaseOrderRow, any>  {

        protected getColumnsKey() { return 'Default.PurchaseOrder'; }
        protected getIdProperty() { return PurchaseOrderRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderRow.localTextPrefix; }
        protected getService() { return PurchaseOrderService.baseUrl; }
        protected getDialogType() { return InspectionDialog; }

        constructor(container: JQuery) {
            super(container);
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

        protected getColumns(): Slick.Column[] {
            var columns = super.getColumns();

            var fld = PurchaseOrderRow.Fields;

            Q.first(columns, x => x.field == fld.Number).format =
                ctx => `<a href="javascript:;" class="customer-link">${Q.htmlEncode(ctx.value)}</a>`;

            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number): void {

            // let base grid handle clicks for its edit links
            super.onClick(e, row, cell);

            // if base grid already handled, we shouldn"t handle it again
            if (e.isDefaultPrevented()) {
                return;
            }
            // get reference to current item
            var item = this.itemAt(row);

            // get reference to clicked element
            var target = $(e.target);

            if (target.hasClass("customer-link")) {
                e.preventDefault();
                var userName = UserRow.getLookup().itemById[item.InsertUserId].DisplayName;
                var detailList = item.OrderDetailsList.filter(x => x.IsAssign === 0);
                var newDetails = InspectionDetailRow[detailList.length];

                if (detailList.length === 0) {
                    Q.notifyError("数据错误，不能创建验收单！");
                    return;
                }

                for (var p of detailList) {
                    var single = Q.deepClone({} as InspectionDetailRow,
                        {
                            InspectionDetailId: p.OrderDetailId,
                            OrderDetailId: p.OrderDetailId,
                            ProductName: p.ProductName,
                            Category: p.Category,
                            Container: p.Container,
                            BlockNumber: p.BlockNumber,
                            Width: p.Width,
                            Height: p.Height,
                            Weight: p.Weight,
                            Volume: p.Volume,
                            Mine: p.Mine,
                            Grade: p.Grade,
                            Notes: p.Notes
                        });
                    newDetails.push(single);
                }

                if (newDetails == null || newDetails.length === 0) {
                    Q.notifyError("数据错误，不能创建验收单！");
                    return;
                }

                if (item.Type == PurchaseType.Stone) {
                    var stonedlg = new InspectionDialog();
                    this.initDialog(stonedlg);
                    stonedlg.loadEntityAndOpenDialog(<InspectionRow>{
                        ParentId: item.PurchaseOrderId,
                        ParentSupplierId: item.SupplierId,
                        ParentNumber: item.Number,
                        ParentType: item.Type,
                        ParentShareType: item.ShareType,
                        UserDisplayName: userName,
                        ParentPurchaseDate: item.PurchaseDate,
                        ParentNotes: item.Notes,
                        OrderDetailsList: newDetails
                    });
                } else {
                    var slabdlg = new PurchaseOrderSlabDialog();
                    this.initDialog(slabdlg);
                    slabdlg.loadByIdAndOpenDialog(item.PurchaseOrderId);
                }
            }
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