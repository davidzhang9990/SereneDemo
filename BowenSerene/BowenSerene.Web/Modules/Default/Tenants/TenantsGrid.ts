
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class TenantsGrid extends Serenity.EntityGrid<TenantsRow, any> {
        protected getColumnsKey() { return 'Default.Tenants'; }
        protected getDialogType() { return TenantsDialog; }
        protected getIdProperty() { return TenantsRow.idProperty; }
        protected getLocalTextPrefix() { return TenantsRow.localTextPrefix; }
        protected getService() { return TenantsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}