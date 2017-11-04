namespace BowenSerene.Default {
    export interface InspectionDetailRow {
        InspectionDetailId?: number;
        ParentId?: number;
        OrderDetailId?: number;
        Container?: string;
        BlockNumber?: string;
        ProductId?: string;
        ProductName?: string;
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
        Category?: string;
        Mine?: string;
        Grade?: string;
    }

    export namespace InspectionDetailRow {
        export const idProperty = 'InspectionDetailId';
        export const localTextPrefix = 'Default.InspectionDetail';

        export namespace Fields {
            export declare const InspectionDetailId: string;
            export declare const ParentId: string;
            export declare const OrderDetailId: string;
            export declare const Container: string;
            export declare const BlockNumber: string;
            export declare const ProductId: string;
            export declare const ProductName: string;
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
            export declare const Category: string;
            export declare const Mine: string;
            export declare const Grade: string;
        }

        [
            'InspectionDetailId', 
            'ParentId', 
            'OrderDetailId', 
            'Container', 
            'BlockNumber', 
            'ProductId', 
            'ProductName', 
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
            'Category', 
            'Mine', 
            'Grade'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

