namespace BowenSerene.Default {
    export interface PurchaseOrderDetailRow {
        PurchaseOrderDetailId?: string;
        ParentId?: string;
        Container?: string;
        BlockNumber?: string;
        ProductId?: string;
        Quantity?: number;
        Length?: number;
        Width?: number;
        Height?: number;
        Thick?: number;
        Size?: number;
        Weight?: number;
        Volume?: number;
        AutoQuantity?: number;
        AutoLength?: number;
        AutoWidth?: number;
        AutoHeight?: number;
        AutoSize?: number;
        AutoWeight?: number;
        AutoVolume?: number;
        IsStock?: number;
        StockDate?: string;
        IsAssign?: number;
        AssignDate?: string;
        IsAssignOrder?: number;
        AssignOrderDate?: string;
        IsFinishType?: number;
        Notes?: string;
        SortCode?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        ParentNumber?: string;
        ParentType?: number;
        ParentShareType?: number;
        ParentPurchaseDate?: string;
        ParentSupplierId?: string;
        ParentLetterNumber?: string;
        ParentAgentNumber?: string;
        ParentPayWay?: number;
        ParentBehalf?: string;
        ParentBillLadingNumber?: string;
        ParentBillLadingDate?: string;
        ParentArrivalDate?: string;
        ParentCompanyShip?: string;
        ParentPortDepart?: string;
        ParentPortDest?: string;
        ParentPriceTerms?: string;
        ParentAttachment?: string;
        ParentNotes?: string;
        ParentStatus?: number;
        ParentInsertDate?: string;
        ParentInsertUserId?: number;
        ParentUpdateDate?: string;
        ParentUpdateUserId?: number;
        ProductNumber?: string;
        ProductName?: string;
        ProductDensity?: number;
        ProductPlace?: string;
        ProductAttach?: string;
        ProductIsActive?: number;
        ProductInsertDate?: string;
        ProductInsertUserId?: number;
        ProductUpdateDate?: string;
        ProductUpdateUserId?: number;
    }

    export namespace PurchaseOrderDetailRow {
        export const idProperty = 'PurchaseOrderDetailId';
        export const nameProperty = 'Container';
        export const localTextPrefix = 'Default.PurchaseOrderDetail';

        export namespace Fields {
            export declare const PurchaseOrderDetailId: string;
            export declare const ParentId: string;
            export declare const Container: string;
            export declare const BlockNumber: string;
            export declare const ProductId: string;
            export declare const Quantity: string;
            export declare const Length: string;
            export declare const Width: string;
            export declare const Height: string;
            export declare const Thick: string;
            export declare const Size: string;
            export declare const Weight: string;
            export declare const Volume: string;
            export declare const AutoQuantity: string;
            export declare const AutoLength: string;
            export declare const AutoWidth: string;
            export declare const AutoHeight: string;
            export declare const AutoSize: string;
            export declare const AutoWeight: string;
            export declare const AutoVolume: string;
            export declare const IsStock: string;
            export declare const StockDate: string;
            export declare const IsAssign: string;
            export declare const AssignDate: string;
            export declare const IsAssignOrder: string;
            export declare const AssignOrderDate: string;
            export declare const IsFinishType: string;
            export declare const Notes: string;
            export declare const SortCode: string;
            export declare const InsertDate: string;
            export declare const InsertUserId: string;
            export declare const UpdateDate: string;
            export declare const UpdateUserId: string;
            export declare const ParentNumber: string;
            export declare const ParentType: string;
            export declare const ParentShareType: string;
            export declare const ParentPurchaseDate: string;
            export declare const ParentSupplierId: string;
            export declare const ParentLetterNumber: string;
            export declare const ParentAgentNumber: string;
            export declare const ParentPayWay: string;
            export declare const ParentBehalf: string;
            export declare const ParentBillLadingNumber: string;
            export declare const ParentBillLadingDate: string;
            export declare const ParentArrivalDate: string;
            export declare const ParentCompanyShip: string;
            export declare const ParentPortDepart: string;
            export declare const ParentPortDest: string;
            export declare const ParentPriceTerms: string;
            export declare const ParentAttachment: string;
            export declare const ParentNotes: string;
            export declare const ParentStatus: string;
            export declare const ParentInsertDate: string;
            export declare const ParentInsertUserId: string;
            export declare const ParentUpdateDate: string;
            export declare const ParentUpdateUserId: string;
            export declare const ProductNumber: string;
            export declare const ProductName: string;
            export declare const ProductDensity: string;
            export declare const ProductPlace: string;
            export declare const ProductAttach: string;
            export declare const ProductIsActive: string;
            export declare const ProductInsertDate: string;
            export declare const ProductInsertUserId: string;
            export declare const ProductUpdateDate: string;
            export declare const ProductUpdateUserId: string;
        }

        [
            'PurchaseOrderDetailId', 
            'ParentId', 
            'Container', 
            'BlockNumber', 
            'ProductId', 
            'Quantity', 
            'Length', 
            'Width', 
            'Height', 
            'Thick', 
            'Size', 
            'Weight', 
            'Volume', 
            'AutoQuantity', 
            'AutoLength', 
            'AutoWidth', 
            'AutoHeight', 
            'AutoSize', 
            'AutoWeight', 
            'AutoVolume', 
            'IsStock', 
            'StockDate', 
            'IsAssign', 
            'AssignDate', 
            'IsAssignOrder', 
            'AssignOrderDate', 
            'IsFinishType', 
            'Notes', 
            'SortCode', 
            'InsertDate', 
            'InsertUserId', 
            'UpdateDate', 
            'UpdateUserId', 
            'ParentNumber', 
            'ParentType', 
            'ParentShareType', 
            'ParentPurchaseDate', 
            'ParentSupplierId', 
            'ParentLetterNumber', 
            'ParentAgentNumber', 
            'ParentPayWay', 
            'ParentBehalf', 
            'ParentBillLadingNumber', 
            'ParentBillLadingDate', 
            'ParentArrivalDate', 
            'ParentCompanyShip', 
            'ParentPortDepart', 
            'ParentPortDest', 
            'ParentPriceTerms', 
            'ParentAttachment', 
            'ParentNotes', 
            'ParentStatus', 
            'ParentInsertDate', 
            'ParentInsertUserId', 
            'ParentUpdateDate', 
            'ParentUpdateUserId', 
            'ProductNumber', 
            'ProductName', 
            'ProductDensity', 
            'ProductPlace', 
            'ProductAttach', 
            'ProductIsActive', 
            'ProductInsertDate', 
            'ProductInsertUserId', 
            'ProductUpdateDate', 
            'ProductUpdateUserId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

