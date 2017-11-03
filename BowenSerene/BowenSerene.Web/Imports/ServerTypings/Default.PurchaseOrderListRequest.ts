namespace BowenSerene.Default {
    export interface PurchaseOrderListRequest extends Serenity.ListRequest {
        ProductId?: string;
        Container?: string;
        IsAssign?: number;
    }
}

