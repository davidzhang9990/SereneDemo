
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class SuppliersGrid extends Serenity.EntityGrid<SuppliersRow, any> {
        protected getColumnsKey() { return 'Default.Suppliers'; }
        protected getDialogType() { return SuppliersDialog; }
        protected getIdProperty() { return SuppliersRow.idProperty; }
        protected getLocalTextPrefix() { return SuppliersRow.localTextPrefix; }
        protected getService() { return SuppliersService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[] {

            let filters = super.getQuickFilters();
            let fld = Default.SuppliersRow.Fields;

            Q.first(filters, x => x.field == fld.IsActive).init = w => {
                (w as Serenity.EnumEditor).value = RowActive.Active.toString();
            };

            return filters;
        }
    }
}