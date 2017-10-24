/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class PurchaseOrderDetailEditor extends Common.GridEditorBase<PurchaseOrderDetailRow>{

        protected validateEntity(row: PurchaseOrderDetailRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;
            //row.PersonFullname = PersonRow.getLookup().itemById[row.PersonId].Fullname;
            return true;
        }
        protected getColumnsKey() {
            return "Default.PurchaseOrderDetail";
        }

        protected getDialogType() {
            return PurchaseOrderDetailEditDialog;
        }

        protected getLocalTextPrefix() {
            return PurchaseOrderDetailRow.localTextPrefix;
        }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
    }
}