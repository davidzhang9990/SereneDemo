namespace BowenSerene.Default {
    export interface ProductsRow {
        ProductId?: string;
        Number?: string;
        Name?: string;
        Density?: number;
        Place?: string;
        Attach?: string;
        IsActive?: RowActive;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ProductsRow {
        export const idProperty = 'ProductId';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Number';
        export const localTextPrefix = 'Default.Products';
        export const lookupKey = 'Default.Products';

        export function getLookup(): Q.Lookup<ProductsRow> {
            return Q.getLookup<ProductsRow>('Default.Products');
        }

        export namespace Fields {
            export declare const ProductId: string;
            export declare const Number: string;
            export declare const Name: string;
            export declare const Density: string;
            export declare const Place: string;
            export declare const Attach: string;
            export declare const IsActive: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'ProductId', 
            'Number', 
            'Name', 
            'Density', 
            'Place', 
            'Attach', 
            'IsActive', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

