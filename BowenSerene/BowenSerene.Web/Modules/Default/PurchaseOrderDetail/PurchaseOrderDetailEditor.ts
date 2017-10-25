/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class PurchaseOrderDetailEditor extends Common.GridEditorBase<PurchaseOrderDetailRow>{

        protected validateEntity(row: PurchaseOrderDetailRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;
            row.Size = 2.11;
            //row.PersonFullname = PersonRow.getLookup().itemById[row.PersonId].Fullname;
            return true;
        }
        protected getColumnsKey() {
            return "Default.PurchaseOrderDetail";
        }

        protected getLocalTextPrefix() {
            return PurchaseOrderDetailRow.localTextPrefix;
        }

        private orderType = 0;

        private pendingChanges: Q.Dictionary<any> = {};

        constructor(container: JQuery) {
            super(container);
            //this.orderType = parent.frames[0].form.Type;
            //  parent.frames[0].form.Type;

            this.slickContainer.on('change', '.edit:input', (e) => this.inputsChange(e));
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

        protected usePager() {
            return false;
        }

        protected onViewProcessData(response) {
            this.pendingChanges = {};
            this.setSaveButtonState();
            return super.onViewProcessData(response);
        }

        //数字输入框
        private numericInputFormatter(ctx) {
            var klass = 'edit numeric';
            var item = ctx.item as PurchaseOrderDetailRow;
            var pending = this.pendingChanges[item.PurchaseOrderDetailId];

            if (pending && pending[ctx.column.field] !== undefined) {
                klass += ' dirty';
            }

            var value = this.getEffectiveValue(item, ctx.column.field) as number;

            return "<input type='text' class='" + klass +
                "' data-field='" + ctx.column.field +
                "' value='" + Q.formatNumber(value, '0.##') + "'/>";
        }
        //文本输入 框
        private stringInputFormatter(ctx) {
            var klass = 'edit string';
            var item = ctx.item as PurchaseOrderDetailRow;
            var pending = this.pendingChanges[item.PurchaseOrderDetailId];
            var column = ctx.column as Slick.Column;

            if (pending && pending[column.field] !== undefined) {
                klass += ' dirty';
            }

            var value = this.getEffectiveValue(item, column.field) as string;

            return "<input type='text' class='" + klass +
                "' data-field='" + column.field +
                "' value='" + Q.htmlEncode(value) +
                "' maxlength='" + column.sourceItem.maxLength + "'/>";
        }
        /**
        * Sorry but you cannot use LookupEditor, e.g. Select2 here, only possible is a SELECT element
        */
        private selectFormatter(ctx: Slick.FormatterContext, idField: string, lookup: Q.Lookup<any>) {
            var fld = PurchaseOrderDetailRow.Fields;
            var klass = 'edit';
            var item = ctx.item as PurchaseOrderDetailRow;
            var pending = this.pendingChanges[item.PurchaseOrderDetailId];
            var column = ctx.column as Slick.Column;

            if (pending && pending[idField] !== undefined) {
                klass += ' dirty';
            }

            var value = this.getEffectiveValue(item, idField);
            var markup = "<select class='" + klass +
                "' data-field='" + idField +
                "' style='width: 100%; max-width: 100%'>";
            for (var c of lookup.items) {
                let id = c[lookup.idField];
                markup += "<option value='" + id + "'";
                if (id == value) {
                    markup += " selected";
                }
                markup += ">" + Q.htmlEncode(c[lookup.textField]) + "</option>";
            }
            return markup + "</select>";
        }
        //格式化列
        protected getColumns() {
            var columns = super.getColumns();
            var num = ctx => this.numericInputFormatter(ctx);
            var str = ctx => this.stringInputFormatter(ctx);
            var fld = PurchaseOrderDetailRow.Fields;

            //增加删除按钮
            columns.unshift({
                field: 'Delete Row',
                name: '',
                format: ctx => '<a class="inline-action delete-row" title="delete">' +
                    '<i class="fa fa-trash-o text-red"></i></a>',
                width: 24,
                minWidth: 24,
                maxWidth: 24
            });

            Q.first(columns, x => x.field === 'Container').format = str;
            Q.first(columns, x => x.field === 'BlockNumber').format = str;

            var product = Q.first(columns, x => x.field === fld.ProductId);
            product.referencedFields = [fld.ProductId];
            product.format = ctx => this.selectFormatter(ctx, fld.ProductId, ProductsRow.getLookup());

            Q.first(columns, x => x.field === 'Weight')
                .groupTotalsFormatter = (totals, col) => (totals.sum ? ('sum: ' + Q.coalesce(Q.formatNumber(totals.sum[col.field], '0.'), '')) : '');

            Q.first(columns, x => x.field === 'Volume')
                .groupTotalsFormatter = (totals, col) => (totals.sum ? ('sum: ' + Q.coalesce(Q.formatNumber(totals.sum[col.field], '0.'), '')) : '');

            Q.first(columns, x => x.field === fld.Length).format = num;
            Q.first(columns, x => x.field === fld.Width).format = num;
            Q.first(columns, x => x.field === fld.Height).format = num;
            Q.first(columns, x => x.field === fld.Weight).format = num;
            return columns;
        }
        //添加行
        private addRow() {
            var row = this.getNewEntity();
            row.PurchaseOrderDetailId = this.getNextId();
            Q.log(this.view.getItems());
            (row as any)[this.getIdProperty()] = this.getNextId();
            var newRow = Q.deepClone({} as PurchaseOrderDetailRow, { Length: 0, Width: 0, Height: this.orderType, Weight: 0.00, Volume: 0.00, Container: '', BlockNumber: parent.name }, row);
            var items = this.view.getItems().slice();
            items.push(newRow);
            this.setEntities(items);
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

        //文本框改变事件
        private inputsChange(e: JQueryEventObject) {
            var cell = this.slickGrid.getCellFromEvent(e);
            var item = this.itemAt(cell.row);
            var input = $(e.target);
            var field = input.data('field');
            var text = Q.coalesce(Q.trimToNull(input.val()), '0');
            var pending = this.pendingChanges[item.PurchaseOrderDetailId];

            var effective = this.getEffectiveValue(item, field);
            var oldText: string;
            if (input.hasClass("numeric"))
                oldText = Q.formatNumber(effective, '0.##');
            else
                oldText = effective as string;

            var value;
            if (field === 'UnitPrice') {
                value = Q.parseDecimal(text);
                if (value == null || isNaN(value)) {
                    Q.notifyError(Q.text('Validation.Decimal'), '', null);
                    input.val(oldText);
                    input.focus();
                    return;
                }
            }
            else if (input.hasClass("numeric")) {
                var i = Q.parseInteger(text);
                if (isNaN(i) || i > 32767 || i < 0) {
                    Q.notifyError(Q.text('Validation.Integer'), '', null);
                    input.val(oldText);
                    input.focus();
                    return;
                }
                value = i;
            }
            else
                value = text;

            if (!pending) {
                this.pendingChanges[item.PurchaseOrderDetailId] = pending = {};
            }

            pending[field] = value;
            item[field] = value;
            this.view.refresh();

            if (input.hasClass("numeric"))
                value = Q.formatNumber(value, '0.##');

            input.val(value).addClass('dirty');

            this.setSaveButtonState();
        }

        private setSaveButtonState() {
            this.toolbar.findButton('apply-changes-button').toggleClass('disabled',
                Object.keys(this.pendingChanges).length === 0);
        }

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.showFooterRow = true;
            return opt;
        }

        private getEffectiveValue(item, field): any {
            var pending = this.pendingChanges[item.PurchaseOrderDetailId];
            if (pending && pending[field] !== undefined) {
                return pending[field];
            }

            return item[field];
        }

        protected getButtons() {
            return [{
                title: '新增',
                cssClass: 'add-button',
                onClick: () => {
                    this.addRow();
                }
            }];
        }
    }
}