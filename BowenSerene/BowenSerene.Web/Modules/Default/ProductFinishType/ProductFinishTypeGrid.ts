
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class ProductFinishTypeGrid extends Serenity.EntityGrid<ProductFinishTypeRow, any> {
        protected getColumnsKey() { return 'Default.ProductFinishType'; }
        protected getDialogType() { return ProductFinishTypeDialog; }
        protected getIdProperty() { return ProductFinishTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ProductFinishTypeRow.localTextPrefix; }
        protected getService() { return ProductFinishTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[] {

            let filters = super.getQuickFilters();
            let fld = Default.ProductFinishTypeRow.Fields;

            Q.first(filters, x => x.field == fld.IsActive).init = w => {
                (w as Serenity.EnumEditor).value = RowActive.Active.toString();
            };

            return filters;
        }
    }
}