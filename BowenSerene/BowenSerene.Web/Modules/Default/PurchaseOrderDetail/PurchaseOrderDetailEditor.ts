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

        protected createSlickGrid() {
            var grid = super.createSlickGrid();

            // need to register this plugin for grouping or you'll have errors
            grid.registerPlugin(new Slick.Data.GroupItemMetadataProvider());

            this.view.setSummaryOptions({
                aggregators: [
                    new Slick.Aggregators.Sum('Weight'),
                    new Slick.Aggregators.Sum('Volume')
                ]
            });

            return grid;
        }

        protected getColumns() {
            var columns = super.getColumns();

            columns.unshift({
                field: 'Delete Row',
                name: '',
                format: ctx => '<a class="inline-action delete-row" title="delete">' +
                    '<i class="fa fa-trash-o text-red"></i></a>',
                width: 24,
                minWidth: 24,
                maxWidth: 24
            });

            Q.first(columns, x => x.field === 'Weight')
                .groupTotalsFormatter = (totals, col) => (totals.sum ? ('sum: ' + Q.coalesce(Q.formatNumber(totals.sum[col.field], '0.'), '')) : '');

            Q.first(columns, x => x.field === 'Volume')
                .groupTotalsFormatter = (totals, col) => (totals.sum ? ('sum: ' + Q.coalesce(Q.formatNumber(totals.sum[col.field], '0.'), '')) : '');

            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;

            var item = this.itemAt(row);
            var target = $(e.target);

            // if user clicks "i" element, e.g. icon
            if (target.parent().hasClass('inline-action'))
                target = target.parent();

            if (target.hasClass('inline-action')) {
                e.preventDefault();

                if (target.hasClass('delete-row')) {
                    Q.confirm('Delete record?', () => {
                        this.view.deleteItem(item.__id);
                        return true;
                    });
                }
            }
        }

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.showFooterRow = true;
            return opt;
        }

        protected getButtons() {
            return [{
                title: this.getAddButtonCaption(),
                cssClass: 'add-button',
                onClick: () => {
                    var row = this.getNewEntity();
                    row.Container = "11";
                    row.BlockNumber = "22";
                    row.Length = 195;
                    row.Width = 185;
                    row.Height = 175;
                    row.Weight = 12;
                    row.Volume = 195 * 185 * 175 / 1000000;
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