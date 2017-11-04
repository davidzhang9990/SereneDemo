namespace BowenSerene.Default {
    export class InspectionForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Inspection';

    }

    export interface InspectionForm {
        ParentId: Serenity.StringEditor;
        ParentSupplierId: Serenity.LookupEditor;
        ParentNumber: Serenity.StringEditor;
        ParentType: Serenity.EnumEditor;
        ParentShareType: Serenity.EnumEditor;
        UserDisplayName: Serenity.StringEditor;
        ParentPurchaseDate: Serenity.DateEditor;
        ParentNotes: Serenity.TextAreaEditor;
        UserId: Serenity.LookupEditor;
        OrderDetailsList: InspectionStoneEditor;
    }

    [['ParentId', () => Serenity.StringEditor], ['ParentSupplierId', () => Serenity.LookupEditor], ['ParentNumber', () => Serenity.StringEditor], ['ParentType', () => Serenity.EnumEditor], ['ParentShareType', () => Serenity.EnumEditor], ['UserDisplayName', () => Serenity.StringEditor], ['ParentPurchaseDate', () => Serenity.DateEditor], ['ParentNotes', () => Serenity.TextAreaEditor], ['UserId', () => Serenity.LookupEditor], ['OrderDetailsList', () => InspectionStoneEditor]].forEach(x => Object.defineProperty(InspectionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

