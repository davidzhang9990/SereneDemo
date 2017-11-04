
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class InspectionDetailDialog extends Serenity.EntityDialog<InspectionDetailRow, any> {
        protected getFormKey() { return InspectionDetailForm.formKey; }
        protected getIdProperty() { return InspectionDetailRow.idProperty; }
        protected getLocalTextPrefix() { return InspectionDetailRow.localTextPrefix; }
        protected getService() { return InspectionDetailService.baseUrl; }

        protected form = new InspectionDetailForm(this.idPrefix);

    }
}