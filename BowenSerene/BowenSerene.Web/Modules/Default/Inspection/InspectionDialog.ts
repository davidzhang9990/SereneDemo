
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class InspectionDialog extends Serenity.EntityDialog<InspectionRow, any> {
        protected getFormKey() { return InspectionForm.formKey; }
        protected getIdProperty() { return InspectionRow.idProperty; }
        protected getLocalTextPrefix() { return InspectionRow.localTextPrefix; }
        protected getService() { return InspectionService.baseUrl; }

        protected form: InspectionForm;

        constructor() {
            super();
            this.form = new InspectionForm(this.idPrefix);
        }

        //#david 加载实体完成事件
        //        loadEntity(entity: InspectionRow) {
        //            super.loadEntity(entity);
        //            if (entity.InspectId == null && entity.ParentId == null) {
        ////                Q.information('页面数据错误，请重新打开页面操作', () => {
        ////                    window.location.href = Q.resolveUrl('~/Account/Login');
        ////                });
        //            }
        //        }

        protected getToolbarButtons(): Serenity.ToolButton[] {
            let buttons = super.getToolbarButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "apply-changes-button"), 1);
           
            buttons.push({
                title: '自定义删除',
                cssClass: 'delete-button',
                onClick: () => {

                    let done = () => {
                        InspectionService.MyCustomDelete({
                            EntityId: this.get_entityId(),
                            InspectionDetails: this.form.OrderDetailsList.value
                        }, response => {
                            this.element.triggerHandler('ondatachange', [{ entityId: this.get_entityId(), entity: this.entity, type: 'delete' }]);
                            this.dialogClose();
                            window.setTimeout(() => Q.notifySuccess("删除成功"), 0);
                        });
                    };
                    Q.confirm("确定要删除该验收单吗？", done);
                }
            });
            return buttons;
        }

        protected validateBeforeSave() {
            if (super.validateBeforeSave()) {
                this.form.OrderDetailsList.setViewDataSelect();
                Q.log("before save event..");
                return true;
            }
            return false;
        }

        protected updateInterface(): void {

            super.updateInterface();
            if (!this.isNew()) {
                this.applyChangesButton.hide();
                this.saveAndCloseButton.hide();
            }
            //this.deleteButton.hide();
            //            Q.log(this.form.UserId.value);
            //            Q.log(this.form.ParentId.value);
        }

        //        //状态是已完成，关闭新增按钮
        //        protected updateInterface(): void {
        //            Q.log("Inspertion");
        //            this.form.Type.value = Default.PurchaseType.Slab.toString();
        //            this.form.ShareType.value = Default.PurchaseShareType.VolumeShare.toString();
        //            //#david#hide
        //            this.form.ShareType.getGridField().toggle(false);

        //        }

    }
}