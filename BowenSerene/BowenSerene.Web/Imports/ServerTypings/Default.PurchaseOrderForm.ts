namespace BowenSerene.Default {
    export class PurchaseOrderForm extends Serenity.PrefixedContext {
        static formKey = 'Default.PurchaseOrder';

    }

    export interface PurchaseOrderForm {
        Number: Serenity.StringEditor;
        Type: Serenity.IntegerEditor;
        ShareType: Serenity.IntegerEditor;
        Status: Serenity.IntegerEditor;
        IsPay: Serenity.IntegerEditor;
        DeleteMark: Serenity.IntegerEditor;
        BuyUserId: Serenity.StringEditor;
        PurchaseDate: Serenity.DateEditor;
        SupplierId: Serenity.StringEditor;
        SupplierNumber: Serenity.StringEditor;
        LetterNumber: Serenity.StringEditor;
        EstimateTotal: Serenity.DecimalEditor;
        ReckonTotal: Serenity.DecimalEditor;
        TotalSize: Serenity.DecimalEditor;
        TotalWeight: Serenity.DecimalEditor;
        TotalVolume: Serenity.DecimalEditor;
        TotalContainer: Serenity.IntegerEditor;
        TotalBuyCount: Serenity.IntegerEditor;
        TotalPieceCount: Serenity.IntegerEditor;
        Notes: Serenity.StringEditor;
        AgentNumber: Serenity.StringEditor;
        PayWay: Serenity.IntegerEditor;
        Behalf: Serenity.StringEditor;
        Ocean: Serenity.DecimalEditor;
        Description: Serenity.StringEditor;
        Attachment: Serenity.StringEditor;
        BillLadingNumber: Serenity.StringEditor;
        BillLadingDate: Serenity.DateEditor;
        ArrivalDate: Serenity.DateEditor;
        CompanyShip: Serenity.StringEditor;
        PortDepart: Serenity.StringEditor;
        PortDest: Serenity.StringEditor;
        PriceTerms: Serenity.IntegerEditor;
        OrganizeId: Serenity.StringEditor;
        InsertUserId: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
    }

    [['Number', () => Serenity.StringEditor], ['Type', () => Serenity.IntegerEditor], ['ShareType', () => Serenity.IntegerEditor], ['Status', () => Serenity.IntegerEditor], ['IsPay', () => Serenity.IntegerEditor], ['DeleteMark', () => Serenity.IntegerEditor], ['BuyUserId', () => Serenity.StringEditor], ['PurchaseDate', () => Serenity.DateEditor], ['SupplierId', () => Serenity.StringEditor], ['SupplierNumber', () => Serenity.StringEditor], ['LetterNumber', () => Serenity.StringEditor], ['EstimateTotal', () => Serenity.DecimalEditor], ['ReckonTotal', () => Serenity.DecimalEditor], ['TotalSize', () => Serenity.DecimalEditor], ['TotalWeight', () => Serenity.DecimalEditor], ['TotalVolume', () => Serenity.DecimalEditor], ['TotalContainer', () => Serenity.IntegerEditor], ['TotalBuyCount', () => Serenity.IntegerEditor], ['TotalPieceCount', () => Serenity.IntegerEditor], ['Notes', () => Serenity.StringEditor], ['AgentNumber', () => Serenity.StringEditor], ['PayWay', () => Serenity.IntegerEditor], ['Behalf', () => Serenity.StringEditor], ['Ocean', () => Serenity.DecimalEditor], ['Description', () => Serenity.StringEditor], ['Attachment', () => Serenity.StringEditor], ['BillLadingNumber', () => Serenity.StringEditor], ['BillLadingDate', () => Serenity.DateEditor], ['ArrivalDate', () => Serenity.DateEditor], ['CompanyShip', () => Serenity.StringEditor], ['PortDepart', () => Serenity.StringEditor], ['PortDest', () => Serenity.StringEditor], ['PriceTerms', () => Serenity.IntegerEditor], ['OrganizeId', () => Serenity.StringEditor], ['InsertUserId', () => Serenity.IntegerEditor], ['InsertDate', () => Serenity.DateEditor], ['UpdateUserId', () => Serenity.IntegerEditor], ['UpdateDate', () => Serenity.DateEditor]].forEach(x => Object.defineProperty(PurchaseOrderForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

