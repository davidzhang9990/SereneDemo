namespace BowenSerene.Default {
    export class PurchaseOrderDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Default.PurchaseOrderDetail';

    }

    export interface PurchaseOrderDetailForm {
        ParentId: Serenity.StringEditor;
        ContainerNumber: Serenity.StringEditor;
        BlockNumber: Serenity.StringEditor;
        ProNumber: Serenity.StringEditor;
        ProName: Serenity.StringEditor;
        ProType: Serenity.StringEditor;
        ProMine: Serenity.StringEditor;
        ProGrade: Serenity.StringEditor;
        ProDensity: Serenity.DecimalEditor;
        BuyCount: Serenity.IntegerEditor;
        Length: Serenity.IntegerEditor;
        Width: Serenity.IntegerEditor;
        Height: Serenity.IntegerEditor;
        Thick: Serenity.DecimalEditor;
        Size: Serenity.DecimalEditor;
        Weight: Serenity.DecimalEditor;
        Volume: Serenity.DecimalEditor;
        IsStock: Serenity.IntegerEditor;
        StockDate: Serenity.DateEditor;
        WarehouseNumber: Serenity.StringEditor;
        AutoBuyCount: Serenity.IntegerEditor;
        AutoLength: Serenity.IntegerEditor;
        AutoWidth: Serenity.IntegerEditor;
        AutoHeight: Serenity.IntegerEditor;
        AutoSize: Serenity.DecimalEditor;
        AutoWeight: Serenity.DecimalEditor;
        AutoVolume: Serenity.DecimalEditor;
        AutoGrade: Serenity.StringEditor;
        IsFinishType: Serenity.IntegerEditor;
        Notes: Serenity.StringEditor;
        SortCode: Serenity.IntegerEditor;
        IsAssignOrder: Serenity.IntegerEditor;
        AssignOrderDate: Serenity.DateEditor;
        IsAssign: Serenity.IntegerEditor;
        AssignDate: Serenity.DateEditor;
        AssignUserId: Serenity.StringEditor;
        AssignUserName: Serenity.StringEditor;
        InsertUserId: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
    }

    [['ParentId', () => Serenity.StringEditor], ['ContainerNumber', () => Serenity.StringEditor], ['BlockNumber', () => Serenity.StringEditor], ['ProNumber', () => Serenity.StringEditor], ['ProName', () => Serenity.StringEditor], ['ProType', () => Serenity.StringEditor], ['ProMine', () => Serenity.StringEditor], ['ProGrade', () => Serenity.StringEditor], ['ProDensity', () => Serenity.DecimalEditor], ['BuyCount', () => Serenity.IntegerEditor], ['Length', () => Serenity.IntegerEditor], ['Width', () => Serenity.IntegerEditor], ['Height', () => Serenity.IntegerEditor], ['Thick', () => Serenity.DecimalEditor], ['Size', () => Serenity.DecimalEditor], ['Weight', () => Serenity.DecimalEditor], ['Volume', () => Serenity.DecimalEditor], ['IsStock', () => Serenity.IntegerEditor], ['StockDate', () => Serenity.DateEditor], ['WarehouseNumber', () => Serenity.StringEditor], ['AutoBuyCount', () => Serenity.IntegerEditor], ['AutoLength', () => Serenity.IntegerEditor], ['AutoWidth', () => Serenity.IntegerEditor], ['AutoHeight', () => Serenity.IntegerEditor], ['AutoSize', () => Serenity.DecimalEditor], ['AutoWeight', () => Serenity.DecimalEditor], ['AutoVolume', () => Serenity.DecimalEditor], ['AutoGrade', () => Serenity.StringEditor], ['IsFinishType', () => Serenity.IntegerEditor], ['Notes', () => Serenity.StringEditor], ['SortCode', () => Serenity.IntegerEditor], ['IsAssignOrder', () => Serenity.IntegerEditor], ['AssignOrderDate', () => Serenity.DateEditor], ['IsAssign', () => Serenity.IntegerEditor], ['AssignDate', () => Serenity.DateEditor], ['AssignUserId', () => Serenity.StringEditor], ['AssignUserName', () => Serenity.StringEditor], ['InsertUserId', () => Serenity.IntegerEditor], ['InsertDate', () => Serenity.DateEditor], ['UpdateUserId', () => Serenity.IntegerEditor], ['UpdateDate', () => Serenity.DateEditor]].forEach(x => Object.defineProperty(PurchaseOrderDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

