
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class InspectionDialog extends Serenity.EntityDialog<InspectionRow, any> {
        protected getFormKey() { return InspectionForm.formKey; }
        protected getIdProperty() { return InspectionRow.idProperty; }
        protected getLocalTextPrefix() { return InspectionRow.localTextPrefix; }
        protected getService() { return InspectionService.baseUrl; }

        protected form = new InspectionForm(this.idPrefix);

        //#david 加载实体完成事件
        loadEntity(entity: InspectionRow) {
            super.loadEntity(entity);
            if (entity.InspectId == null && entity.ParentId == null) {
                Q.information('页面数据错误，请重新打开页面操作', () => {
                    window.location.href = Q.resolveUrl('~/Account/Login');
                });
                //                Q.information(Q.text('Forms.Membership.ResetPassword.Success'), () => {
                //                    window.location.href = Q.resolveUrl('~/Account/Login');
                //                });
            }
        }
        //        //状态是已完成，关闭新增按钮
        //        protected updateInterface(): void {
        //            Q.log("Inspertion");
        //            this.form.Type.value = Default.PurchaseType.Slab.toString();
        //            this.form.ShareType.value = Default.PurchaseShareType.VolumeShare.toString();
        //            //#david#hide
        //            this.form.ShareType.getGridField().toggle(false);
        //            if (this.entity.Status === 1) {
        //                this.element.find('.add-button').hide();
        //            }
        //        }

    }
}