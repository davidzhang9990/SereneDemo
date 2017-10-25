/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace BowenSerene.Default {
    import ToolButton = Serenity.ToolButton;

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

        protected getButtons() {
            return [{
                title: this.getAddButtonCaption(),
                cssClass: 'add-button',
                onClick: () => {
                    var row = this.getNewEntity();
                    (row as any)[this.getIdProperty()] = this.getNextId();
                    var items = this.view.getItems().slice();
                    items.push(row);
                    //            else {
                    //                var index = Q.indexOf(items, x => this.id(x) === id);
                    //                items[index] = Q.deepClone({} as TEntity, items[index], row);
                    //            }

                    this.setEntities(items);
                }
            }];
        }
    }
}