namespace BowenSerene.Default {
    export interface PurchaseOrderRow {
        Id?: string;
        Number?: string;
        Type?: number;
        ShareType?: number;
        Status?: number;
        IsPay?: number;
        DeleteMark?: number;
        BuyUserId?: string;
        PurchaseDate?: string;
        SupplierId?: string;
        SupplierNumber?: string;
        LetterNumber?: string;
        EstimateTotal?: number;
        ReckonTotal?: number;
        TotalSize?: number;
        TotalWeight?: number;
        TotalVolume?: number;
        TotalContainer?: number;
        TotalBuyCount?: number;
        TotalPieceCount?: number;
        Notes?: string;
        AgentNumber?: string;
        PayWay?: number;
        Behalf?: string;
        Ocean?: number;
        Description?: string;
        Attachment?: string;
        BillLadingNumber?: string;
        BillLadingDate?: string;
        ArrivalDate?: string;
        CompanyShip?: string;
        PortDepart?: string;
        PortDest?: string;
        PriceTerms?: number;
        OrganizeId?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace PurchaseOrderRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Id';
        export const localTextPrefix = 'Default.PurchaseOrder';

        export namespace Fields {
            export declare const Id: string;
            export declare const Number: string;
            export declare const Type: string;
            export declare const ShareType: string;
            export declare const Status: string;
            export declare const IsPay: string;
            export declare const DeleteMark: string;
            export declare const BuyUserId: string;
            export declare const PurchaseDate: string;
            export declare const SupplierId: string;
            export declare const SupplierNumber: string;
            export declare const LetterNumber: string;
            export declare const EstimateTotal: string;
            export declare const ReckonTotal: string;
            export declare const TotalSize: string;
            export declare const TotalWeight: string;
            export declare const TotalVolume: string;
            export declare const TotalContainer: string;
            export declare const TotalBuyCount: string;
            export declare const TotalPieceCount: string;
            export declare const Notes: string;
            export declare const AgentNumber: string;
            export declare const PayWay: string;
            export declare const Behalf: string;
            export declare const Ocean: string;
            export declare const Description: string;
            export declare const Attachment: string;
            export declare const BillLadingNumber: string;
            export declare const BillLadingDate: string;
            export declare const ArrivalDate: string;
            export declare const CompanyShip: string;
            export declare const PortDepart: string;
            export declare const PortDest: string;
            export declare const PriceTerms: string;
            export declare const OrganizeId: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'Id', 
            'Number', 
            'Type', 
            'ShareType', 
            'Status', 
            'IsPay', 
            'DeleteMark', 
            'BuyUserId', 
            'PurchaseDate', 
            'SupplierId', 
            'SupplierNumber', 
            'LetterNumber', 
            'EstimateTotal', 
            'ReckonTotal', 
            'TotalSize', 
            'TotalWeight', 
            'TotalVolume', 
            'TotalContainer', 
            'TotalBuyCount', 
            'TotalPieceCount', 
            'Notes', 
            'AgentNumber', 
            'PayWay', 
            'Behalf', 
            'Ocean', 
            'Description', 
            'Attachment', 
            'BillLadingNumber', 
            'BillLadingDate', 
            'ArrivalDate', 
            'CompanyShip', 
            'PortDepart', 
            'PortDest', 
            'PriceTerms', 
            'OrganizeId', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

