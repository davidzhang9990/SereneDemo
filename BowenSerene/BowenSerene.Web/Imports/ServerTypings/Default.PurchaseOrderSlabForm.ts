namespace BowenSerene.Default {
    export class PurchaseOrderSlabForm extends Serenity.PrefixedContext {
        static formKey = 'Default.PurchaseOrderSlab';

    }

    export interface PurchaseOrderSlabForm {
        Number: Serenity.StringEditor;
        PurchaseDate: Serenity.DateEditor;
        Type: Serenity.EnumEditor;
        ShareType: Serenity.EnumEditor;
        SupplierId: Serenity.LookupEditor;
        PayWay: Serenity.EnumEditor;
        Notes: Serenity.TextAreaEditor;
        LetterNumber: Serenity.StringEditor;
        AgentNumber: Serenity.StringEditor;
        Behalf: Serenity.StringEditor;
        BillLadingNumber: Serenity.StringEditor;
        BillLadingDate: Serenity.DateEditor;
        ArrivalDate: Serenity.DateEditor;
        CompanyShip: Serenity.StringEditor;
        PortDepart: Serenity.StringEditor;
        PortDest: Serenity.StringEditor;
        PriceTerms: Serenity.StringEditor;
        Attachment: Serenity.MultipleImageUploadEditor;
        OrderDetailsList: PurchaseOrderSlabEditor;
    }

    [['Number', () => Serenity.StringEditor], ['PurchaseDate', () => Serenity.DateEditor], ['Type', () => Serenity.EnumEditor], ['ShareType', () => Serenity.EnumEditor], ['SupplierId', () => Serenity.LookupEditor], ['PayWay', () => Serenity.EnumEditor], ['Notes', () => Serenity.TextAreaEditor], ['LetterNumber', () => Serenity.StringEditor], ['AgentNumber', () => Serenity.StringEditor], ['Behalf', () => Serenity.StringEditor], ['BillLadingNumber', () => Serenity.StringEditor], ['BillLadingDate', () => Serenity.DateEditor], ['ArrivalDate', () => Serenity.DateEditor], ['CompanyShip', () => Serenity.StringEditor], ['PortDepart', () => Serenity.StringEditor], ['PortDest', () => Serenity.StringEditor], ['PriceTerms', () => Serenity.StringEditor], ['Attachment', () => Serenity.MultipleImageUploadEditor], ['OrderDetailsList', () => PurchaseOrderSlabEditor]].forEach(x => Object.defineProperty(PurchaseOrderSlabForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

