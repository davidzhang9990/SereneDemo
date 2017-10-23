namespace BowenSerene.Default {
    export interface PurchaseOrderDetailRow {
        Id?: string;
        ParentId?: string;
        ContainerNumber?: string;
        BlockNumber?: string;
        ProNumber?: string;
        ProName?: string;
        ProType?: string;
        ProMine?: string;
        ProGrade?: string;
        ProDensity?: number;
        BuyCount?: number;
        Length?: number;
        Width?: number;
        Height?: number;
        Thick?: number;
        Size?: number;
        Weight?: number;
        Volume?: number;
        IsStock?: number;
        StockDate?: string;
        WarehouseNumber?: string;
        AutoBuyCount?: number;
        AutoLength?: number;
        AutoWidth?: number;
        AutoHeight?: number;
        AutoSize?: number;
        AutoWeight?: number;
        AutoVolume?: number;
        AutoGrade?: string;
        IsFinishType?: number;
        Notes?: string;
        SortCode?: number;
        IsAssignOrder?: number;
        AssignOrderDate?: string;
        IsAssign?: number;
        AssignDate?: string;
        AssignUserId?: string;
        AssignUserName?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace PurchaseOrderDetailRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Id';
        export const localTextPrefix = 'Default.PurchaseOrderDetail';

        export namespace Fields {
            export declare const Id: string;
            export declare const ParentId: string;
            export declare const ContainerNumber: string;
            export declare const BlockNumber: string;
            export declare const ProNumber: string;
            export declare const ProName: string;
            export declare const ProType: string;
            export declare const ProMine: string;
            export declare const ProGrade: string;
            export declare const ProDensity: string;
            export declare const BuyCount: string;
            export declare const Length: string;
            export declare const Width: string;
            export declare const Height: string;
            export declare const Thick: string;
            export declare const Size: string;
            export declare const Weight: string;
            export declare const Volume: string;
            export declare const IsStock: string;
            export declare const StockDate: string;
            export declare const WarehouseNumber: string;
            export declare const AutoBuyCount: string;
            export declare const AutoLength: string;
            export declare const AutoWidth: string;
            export declare const AutoHeight: string;
            export declare const AutoSize: string;
            export declare const AutoWeight: string;
            export declare const AutoVolume: string;
            export declare const AutoGrade: string;
            export declare const IsFinishType: string;
            export declare const Notes: string;
            export declare const SortCode: string;
            export declare const IsAssignOrder: string;
            export declare const AssignOrderDate: string;
            export declare const IsAssign: string;
            export declare const AssignDate: string;
            export declare const AssignUserId: string;
            export declare const AssignUserName: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'Id', 
            'ParentId', 
            'ContainerNumber', 
            'BlockNumber', 
            'ProNumber', 
            'ProName', 
            'ProType', 
            'ProMine', 
            'ProGrade', 
            'ProDensity', 
            'BuyCount', 
            'Length', 
            'Width', 
            'Height', 
            'Thick', 
            'Size', 
            'Weight', 
            'Volume', 
            'IsStock', 
            'StockDate', 
            'WarehouseNumber', 
            'AutoBuyCount', 
            'AutoLength', 
            'AutoWidth', 
            'AutoHeight', 
            'AutoSize', 
            'AutoWeight', 
            'AutoVolume', 
            'AutoGrade', 
            'IsFinishType', 
            'Notes', 
            'SortCode', 
            'IsAssignOrder', 
            'AssignOrderDate', 
            'IsAssign', 
            'AssignDate', 
            'AssignUserId', 
            'AssignUserName', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

