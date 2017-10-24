namespace BowenSerene.Default {
    export interface SuppliersRow {
        SupplierId?: string;
        Number?: string;
        Name?: string;
        Country?: string;
        Suffix?: string;
        Place?: string;
        Notes?: string;
        IsActive?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
    }

    export namespace SuppliersRow {
        export const idProperty = 'SupplierId';
        export const nameProperty = 'Number';
        export const localTextPrefix = 'Default.Suppliers';

        export namespace Fields {
            export declare const SupplierId: string;
            export declare const Number: string;
            export declare const Name: string;
            export declare const Country: string;
            export declare const Suffix: string;
            export declare const Place: string;
            export declare const Notes: string;
            export declare const IsActive: string;
            export declare const InsertDate: string;
            export declare const InsertUserId: string;
            export declare const UpdateDate: string;
            export declare const UpdateUserId: string;
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
            'InsertDate', 
            'InsertUserId', 
            'UpdateDate', 
            'UpdateUserId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

