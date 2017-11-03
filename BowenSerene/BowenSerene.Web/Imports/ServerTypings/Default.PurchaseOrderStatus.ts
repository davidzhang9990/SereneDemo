namespace BowenSerene.Default {
    export enum PurchaseOrderStatus {
        VolumeShare = 0,
        WeightShare = 1
    }
    Serenity.Decorators.registerEnum(PurchaseOrderStatus, 'Purchase.OrderStatus');
}

