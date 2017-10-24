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
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
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
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
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
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

