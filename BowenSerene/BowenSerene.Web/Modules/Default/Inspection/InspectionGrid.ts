
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

        //david 设置页面按钮
        protected getButtons() {
            var buttons = super.getButtons();
            //删除添加按钮
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
            return buttons;
        }
    }
}