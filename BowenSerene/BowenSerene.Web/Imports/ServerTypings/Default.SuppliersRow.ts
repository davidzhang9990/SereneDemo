namespace BowenSerene.Default {
    export interface SuppliersRow {
        SupplierId?: string;
        Number?: string;
        Name?: string;
        Country?: string;
        Suffix?: string;
        Place?: string;
        Notes?: string;
        IsActive?: RowActive;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace SuppliersRow {
        export const idProperty = 'SupplierId';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.Suppliers';
        export const lookupKey = 'Default.Suppliers';

        export function getLookup(): Q.Lookup<SuppliersRow> {
            return Q.getLookup<SuppliersRow>('Default.Suppliers');
        }

        export namespace Fields {
            export declare const SupplierId: string;
            export declare const Number: string;
            export declare const Name: string;
            export declare const Country: string;
            export declare const Suffix: string;
            export declare const Place: string;
            export declare const Notes: string;
            export declare const IsActive: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'SupplierId', 
            'Number', 
            'Name', 
            'Country', 
            'Suffix', 
            'Place', 
            'Notes', 
            'IsActive', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

