namespace BowenSerene.Administration {
    export interface RoleRow {
        RoleId?: number;
        RoleName?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace RoleRow {
        export const idProperty = 'RoleId';
        export const nameProperty = 'RoleName';
        export const localTextPrefix = 'Administration.Role';
        export const lookupKey = 'Administration.Role';

        export function getLookup(): Q.Lookup<RoleRow> {
            return Q.getLookup<RoleRow>('Administration.Role');
        }

        export namespace Fields {
            export declare const RoleId: string;
            export declare const RoleName: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'RoleId', 
            'RoleName', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

