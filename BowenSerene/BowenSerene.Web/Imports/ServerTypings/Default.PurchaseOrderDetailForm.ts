namespace BowenSerene.Default {
    export class PurchaseOrderDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Default.PurchaseOrderDetail';

    }

    export interface PurchaseOrderDetailForm {
        ParentId: Serenity.StringEditor;
        Container: Serenity.StringEditor;
        BlockNumber: Serenity.StringEditor;
        ProductId: Serenity.StringEditor;
        Quantity: Serenity.IntegerEditor;
        Length: Serenity.IntegerEditor;
        Width: Serenity.IntegerEditor;
        Height: Serenity.IntegerEditor;
        Thick: Serenity.DecimalEditor;
        Size: Serenity.DecimalEditor;
        Weight: Serenity.DecimalEditor;
        Volume: Serenity.DecimalEditor;
        AutoQuantity: Serenity.IntegerEditor;
        AutoLength: Serenity.IntegerEditor;
        AutoWidth: Serenity.IntegerEditor;
        AutoHeight: Serenity.IntegerEditor;
        AutoSize: Serenity.DecimalEditor;
        AutoWeight: Serenity.DecimalEditor;
        AutoVolume: Serenity.DecimalEditor;
        IsStock: Serenity.IntegerEditor;
        StockDate: Serenity.DateEditor;
        IsAssign: Serenity.IntegerEditor;
        AssignDate: Serenity.DateEditor;
        IsAssignOrder: Serenity.IntegerEditor;
        AssignOrderDate: Serenity.DateEditor;
        IsFinishType: Serenity.IntegerEditor;
        Notes: Serenity.StringEditor;
        SortCode: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
    }

    [['ParentId', () => Serenity.StringEditor], ['Container', () => Serenity.StringEditor], ['BlockNumber', () => Serenity.StringEditor], ['ProductId', () => Serenity.StringEditor], ['Quantity', () => Serenity.IntegerEditor], ['Length', () => Serenity.IntegerEditor], ['Width', () => Serenity.IntegerEditor], ['Height', () => Serenity.IntegerEditor], ['Thick', () => Serenity.DecimalEditor], ['Size', () => Serenity.DecimalEditor], ['Weight', () => Serenity.DecimalEditor], ['Volume', () => Serenity.DecimalEditor], ['AutoQuantity', () => Serenity.IntegerEditor], ['AutoLength', () => Serenity.IntegerEditor], ['AutoWidth', () => Serenity.IntegerEditor], ['AutoHeight', () => Serenity.IntegerEditor], ['AutoSize', () => Serenity.DecimalEditor], ['AutoWeight', () => Serenity.DecimalEditor], ['AutoVolume', () => Serenity.DecimalEditor], ['IsStock', () => Serenity.IntegerEditor], ['StockDate', () => Serenity.DateEditor], ['IsAssign', () => Serenity.IntegerEditor], ['AssignDate', () => Serenity.DateEditor], ['IsAssignOrder', () => Serenity.IntegerEditor], ['AssignOrderDate', () => Serenity.DateEditor], ['IsFinishType', () => Serenity.IntegerEditor], ['Notes', () => Serenity.StringEditor], ['SortCode', () => Serenity.IntegerEditor], ['InsertDate', () => Serenity.DateEditor], ['InsertUserId', () => Serenity.IntegerEditor], ['UpdateDate', () => Serenity.DateEditor], ['UpdateUserId', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(PurchaseOrderDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

