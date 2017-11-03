
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class ProductsGrid extends Serenity.EntityGrid<ProductsRow, any> {
        protected getColumnsKey() { return 'Default.Products'; }
        protected getDialogType() { return ProductsDialog; }
        protected getIdProperty() { return ProductsRow.idProperty; }
        protected getLocalTextPrefix() { return ProductsRow.localTextPrefix; }
        protected getService() { return ProductsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[] {

            let filters = super.getQuickFilters();
            let fld = Default.ProductsRow.Fields;

            Q.first(filters, x => x.field == fld.IsActive).init = w => {
                (w as Serenity.EnumEditor).value = RowActive.Active.toString();
            };

            return filters;
        }

    }
}