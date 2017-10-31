namespace BowenSerene.Default {
    export interface PurchaseOrderRow {
        PurchaseOrderId?: string;
        Number?: string;
        Type?: PurchaseType;
        ShareType?: PurchaseShareType;
        PurchaseDate?: string;
        SupplierId?: string;
        OrderDetailsList?: PurchaseOrderDetailRow[];
        LetterNumber?: string;
        AgentNumber?: string;
        PayWay?: PurchasePayWay;
        Behalf?: string;
        BillLadingNumber?: string;
        BillLadingDate?: string;
        ArrivalDate?: string;
        CompanyShip?: string;
        PortDepart?: string;
        PortDest?: string;
        PriceTerms?: string;
        Attachment?: string;
        Notes?: string;
        Status?: number;
        SupplierName?: string;
        SupplierSuffix?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace PurchaseOrderRow {
        export const idProperty = 'PurchaseOrderId';
        export const nameProperty = 'Number';
        export const localTextPrefix = 'Default.PurchaseOrder';

        export namespace Fields {
            export declare const PurchaseOrderId: string;
            export declare const Number: string;
            export declare const Type: string;
            export declare const ShareType: string;
            export declare const PurchaseDate: string;
            export declare const SupplierId: string;
            export declare const OrderDetailsList: string;
            export declare const LetterNumber: string;
            export declare const AgentNumber: string;
            export declare const PayWay: string;
            export declare const Behalf: string;
            export declare const BillLadingNumber: string;
            export declare const BillLadingDate: string;
            export declare const ArrivalDate: string;
            export declare const CompanyShip: string;
            export declare const PortDepart: string;
            export declare const PortDest: string;
            export declare const PriceTerms: string;
            export declare const Attachment: string;
            export declare const Notes: string;
            export declare const Status: string;
            export declare const SupplierName: string;
            export declare const SupplierSuffix: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'PurchaseOrderId', 
            'Number', 
            'Type', 
            'ShareType', 
            'PurchaseDate', 
            'SupplierId', 
            'OrderDetailsList', 
            'LetterNumber', 
            'AgentNumber', 
            'PayWay', 
            'Behalf', 
            'BillLadingNumber', 
            'BillLadingDate', 
            'ArrivalDate', 
            'CompanyShip', 
            'PortDepart', 
            'PortDest', 
            'PriceTerms', 
            'Attachment', 
            'Notes', 
            'Status', 
            'SupplierName', 
            'SupplierSuffix', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

