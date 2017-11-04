namespace BowenSerene.Default {
    export interface InspectionRow {
        InspectId?: number;
        ParentId?: string;
        UserId?: number;
        ParentNumber?: string;
        ParentType?: PurchaseType;
        ParentShareType?: PurchaseShareType;
        ParentPurchaseDate?: string;
        OrderDetailsList?: InspectionDetailRow[];
        ParentSupplierId?: string;
        ParentNotes?: string;
        ParentInsertUserId?: number;
        UserUsername?: string;
        UserDisplayName?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace InspectionRow {
        export const idProperty = 'InspectId';
        export const localTextPrefix = 'Default.Inspection';

        export namespace Fields {
            export declare const InspectId: string;
            export declare const ParentId: string;
            export declare const UserId: string;
            export declare const ParentNumber: string;
            export declare const ParentType: string;
            export declare const ParentShareType: string;
            export declare const ParentPurchaseDate: string;
            export declare const OrderDetailsList: string;
            export declare const ParentSupplierId: string;
            export declare const ParentNotes: string;
            export declare const ParentInsertUserId: string;
            export declare const UserUsername: string;
            export declare const UserDisplayName: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'InspectId', 
            'ParentId', 
            'UserId', 
            'ParentNumber', 
            'ParentType', 
            'ParentShareType', 
            'ParentPurchaseDate', 
            'OrderDetailsList', 
            'ParentSupplierId', 
            'ParentNotes', 
            'ParentInsertUserId', 
            'UserUsername', 
            'UserDisplayName', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

