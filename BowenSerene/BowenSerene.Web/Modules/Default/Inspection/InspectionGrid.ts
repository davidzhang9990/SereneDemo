
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class InspectionGrid extends Serenity.EntityGrid<InspectionRow, any> {
        protected getColumnsKey() { return 'Default.Inspection'; }
        protected getDialogType() { return InspectionDialog; }
        protected getIdProperty() { return InspectionRow.idProperty; }
        protected getLocalTextPrefix() { return InspectionRow.localTextPrefix; }
        protected getService() { return InspectionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}