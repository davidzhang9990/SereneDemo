/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class PurchaseOrderStoneEditor extends Common.GridEditorBase<PurchaseOrderDetailRow>{

        protected getColumnsKey() {
            return "Default.PurchaseOrderStone";
        }

        protected getLocalTextPrefix() {
            return PurchaseOrderDetailRow.localTextPrefix;
        }
        public place: string;

        private pendingChanges: Q.Dictionary<any> = {};

        constructor(container: JQuery) {
            super(container);
            this.slickContainer
                .on('keyup', '.edit:input', (e) => this.inputsChange(e))
                .on('change', 'select', (e) => this.productsChange(e));
            //this.slickContainer.on('keydown', '.edit:input', (e) => this.inputsNext(e));
        }

        protected createSlickGrid() {

            var grid = super.createSlickGrid();
            //let autoSize = new Slick.AutoColumnSize(true); // *** If you want to make it autoresize when grid is loaded, use: new Slick.AutoColumnSize(true);
            // grid.registerPlugin(autoSize);
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

        private getEffectiveValue(item, field): any {
            var pending = this.pendingChanges[item.OrderDetailId];
            if (pending && pending[field] !== undefined) {
                return pending[field];
            }
            return item[field];
        }

        //品目改变事件
        private productsChange(e: JQueryEventObject) {

            var select = $(e.target);
            var scell = this.slickGrid.getCellFromEvent(e);
            var single = this.itemAt(scell.row);
            var field = select.data('field');
            var productId = Q.coalesce(Q.trimToNull(select.val()), '0');
            var proName = ProductsRow.getLookup().items.filter(x => x.ProductId == productId)[0].Name;

            single[field] = productId;
            single.ProductName = proName;
            this.view.refresh();
        }
        //文本框改变事件
        private inputsChange(e: JQueryEventObject) {

            var input = $(e.target);
            var key = e.which;
            //next
            if (key === 13) {
                event.preventDefault();
                var parent = input.parent().parent();
                var nxtIdx = parent.find("input").index(input) + 1;
                var nextselector = parent.find("input:eq(" + nxtIdx + ")");
                nextselector.focus();
                nextselector.select();
                return;
            }
            var cell = this.slickGrid.getCellFromEvent(e);
            var item = this.itemAt(cell.row);
            var field = input.data('field');
            var text = Q.coalesce(Q.trimToNull(input.val()), '0');

            var effective = this.getEffectiveValue(item, field);
            var oldText: string;
            if (input.hasClass("numeric"))
                oldText = Q.formatNumber(effective, '0.##');
            else if (input.hasClass("decimal"))
                oldText = Q.formatNumber(effective, '0.00');
            else
                oldText = effective as string;

            var value;
            if (input.hasClass("decimal")) {
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
                item[field] = value;
                //计算体积
                var volumn = item["Length"] * item["Width"] * item["Height"] / 1000000;
                item["Volume"] = volumn;
                input.parent().parent().find("input[data-field='Volume']").val(Q.formatNumber(volumn, '0.00'));
            }
            else
                value = text;

            item[field] = value;
            this.view.refresh();

            if (input.hasClass("numeric"))
                value = Q.formatNumber(value, '0.##');

            input.val(value).addClass('dirty');
        }

        //数字输入框
        private numericInputFormatter(ctx) {
            var klass = 'edit numeric';
            var item = ctx.item as PurchaseOrderDetailRow;
            var pending = this.pendingChanges[item.OrderDetailId];

            if (pending && pending[ctx.column.field] !== undefined) {
                klass += ' dirty';
            }

            var value = this.getEffectiveValue(item, ctx.column.field) as number;

            return "<input type='text' class='" + klass +
                "' data-field='" + ctx.column.field +
                "' value='" + Q.formatNumber(value, '0.##') + "'/>";
        }
        //浮点数输入框
        private floatInputFormatter(ctx) {
            var klass = 'edit decimal';
            var item = ctx.item as PurchaseOrderDetailRow;
            var pending = this.pendingChanges[item.OrderDetailId];

            if (pending && pending[ctx.column.field] !== undefined) {
                klass += ' dirty';
            }

            var value = this.getEffectiveValue(item, ctx.column.field) as number;

            return "<input type='text' class='" + klass +
                "' data-field='" + ctx.column.field +
                "' value='" + Q.formatNumber(value, '0.00') + "'/>";
        }
        //文本输入 框
        private stringInputFormatter(ctx) {
            var klass = 'edit string';
            var item = ctx.item as PurchaseOrderDetailRow;
            var pending = this.pendingChanges[item.OrderDetailId];
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
            var pending = this.pendingChanges[item.OrderDetailId];
            var column = ctx.column as Slick.Column;

            if (pending && pending[idField] !== undefined) {
                klass += ' dirty';
            }
            var value = this.getEffectiveValue(item, idField);
            var markup = "<select class='" + klass +
                "' data-field='" + idField +
                "' style='width: 100%; max-width: 100%'>"
                + " <option value=''>请选择</option>";

            var itemJson = lookup.items.filter(x => x.Place == this.place);
            for (var c of itemJson) {
                let id = c[lookup.idField];
                markup += "<option value='" + id + "'";
                if (id == value) { //|| itemJson.length == 1
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
            var decimal = ctx => this.floatInputFormatter(ctx);
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
            Q.first(columns, x => x.field === 'Category').format = str;
            Q.first(columns, x => x.field === 'Mine').format = str;
            Q.first(columns, x => x.field === 'Grade').format = str;
            Q.first(columns, x => x.field === 'Notes').format = str;

            var product = Q.first(columns, x => x.field === fld.ProductId);
            product.referencedFields = [fld.ProductId];
            product.format = ctx => this.selectFormatter(ctx, fld.ProductId, ProductsRow.getLookup());

            Q.first(columns, x => x.field === 'Weight')
                .groupTotalsFormatter = (totals, col) => (totals.sum ? ('重量: ' + Q.coalesce(Q.formatNumber(totals.sum[col.field], '0.00'), '')) : '');

            Q.first(columns, x => x.field === 'Volume')
                .groupTotalsFormatter = (totals, col) => (totals.sum ? ('体积: ' + Q.coalesce(Q.formatNumber(totals.sum[col.field], '0.00'), '')) : '');

            Q.first(columns, x => x.field === fld.Length).format = num;
            Q.first(columns, x => x.field === fld.Width).format = num;
            Q.first(columns, x => x.field === fld.Height).format = num;
            Q.first(columns, x => x.field === fld.Weight).format = decimal;
            Q.first(columns, x => x.field === fld.Volume).format = decimal;

            return columns;
        }

        protected getIdProperty() { return "__id"; }

        protected getButtons() {
            return [
                {
                    title: '新增',
                    cssClass: 'add-button',
                    onClick: () => {

                        var row = this.getNewEntity();
                        var items = this.view.getItems().slice();
                        (row as any)[this.getIdProperty()] = this.getNextId();
                        var newRow = Q.deepClone({} as PurchaseOrderDetailRow,
                            {
                                OrderDetailId: items.length + 100,
                                Length: 0,
                                Width: 0,
                                Height: 0,
                                Weight: 0.00,
                                Volume: 0.00,
                                Container: '',
                                BlockNumber: ''
                            },
                            row);

                        //                        if (!this.validateEntity(newRow)) {
                        //                            return;
                        //                        }

                        items.push(newRow);
                        this.setEntities(items);
                    }
                }, {
                    title: '货柜分组',
                    cssClass: 'expand-all-button',
                    onClick: () => this.view.setGrouping(
                        [{
                            formatter: x => '货柜号: ' + x.value + ' (' + x.count + ' items)',
                            getter: 'Container'
                        }, {
                            formatter: x => '荒料号: ' + x.value + ' (' + x.count + ' items)',
                            getter: 'BlockNumber'
                        }])
                }, {
                    title: '品目分组',
                    cssClass: 'expand-all-button',
                    onClick: () => this.view.setGrouping(
                        [{
                            formatter: x => '品目: ' + x.value + ' (' + x.count + ' items)',
                            getter: 'ProductName'
                        }, {
                            formatter: x => '类别: ' + x.value + ' (' + x.count + ' items)',
                            getter: 'Category'
                        }])
                },
                {
                    title: 'No Grouping',
                    cssClass: 'collapse-all-button',
                    onClick: () => this.view.setGrouping([])
                }
            ];
        }

        public clearView() {
            var items = this.view.getItems().slice();
            for (var c of items) {
                this.view.deleteItem(c.__id);
            }
        }

        //        protected getItemCssClass(item: PurchaseOrderDetailRow, index: number): string {
        //            let klass: string = "";
        //
        //            if (item.Width == 0)
        //                klass += " discontinued";
        //            else if (item.UnitsInStock <= 0)
        //                klass += " out-of-stock";
        //            else if (item.UnitsInStock < 20)
        //                klass += " critical-stock";
        //            else if (item.UnitsInStock > 50)
        //                klass += " needs-reorder";
        //
        //            if (item.UnitPrice >= 50)
        //                klass += " high-price";
        //            else if (item.UnitPrice >= 20)
        //                klass += " medium-price";
        //            else
        //                klass += " low-price";
        //
        //            return Q.trimToNull(klass);
        //        }

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
                    this.view.deleteItem(item.__id);
                    return true;
                    //                    Q.confirm('Delete record?', () => {
                    //                        this.view.deleteItem(item.__id);
                    //                        return true;
                    //                    });
                }
            }
        }

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.showFooterRow = true;
            return opt;
        }
    }
}