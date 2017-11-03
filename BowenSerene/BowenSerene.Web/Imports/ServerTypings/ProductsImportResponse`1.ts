namespace BowenSerene {
    export interface ProductsImportResponse<T> extends Serenity.ListResponse<T> {
        ErrorList?: string[];
    }
}

