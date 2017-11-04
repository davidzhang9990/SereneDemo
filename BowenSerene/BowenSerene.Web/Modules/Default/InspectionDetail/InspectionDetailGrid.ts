
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class InspectionDetailGrid extends Serenity.EntityGrid<InspectionDetailRow, any> {
        protected getColumnsKey() { return 'Default.InspectionDetail'; }
        protected getDialogType() { return InspectionDetailDialog; }
        protected getIdProperty() { return InspectionDetailRow.idProperty; }
        protected getLocalTextPrefix() { return InspectionDetailRow.localTextPrefix; }
        protected getService() { return InspectionDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}