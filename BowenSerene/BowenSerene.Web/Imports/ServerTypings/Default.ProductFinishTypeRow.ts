namespace BowenSerene.Default {
    export interface ProductFinishTypeRow {
        FinishTypeId?: number;
        Name?: string;
        SortCode?: number;
        IsActive?: RowActive;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ProductFinishTypeRow {
        export const idProperty = 'FinishTypeId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.ProductFinishType';
        export const lookupKey = 'Default.ProductFinishType';

        export function getLookup(): Q.Lookup<ProductFinishTypeRow> {
            return Q.getLookup<ProductFinishTypeRow>('Default.ProductFinishType');
        }

        export namespace Fields {
            export declare const FinishTypeId: string;
            export declare const Name: string;
            export declare const SortCode: string;
            export declare const IsActive: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'FinishTypeId', 
            'Name', 
            'SortCode', 
            'IsActive', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

