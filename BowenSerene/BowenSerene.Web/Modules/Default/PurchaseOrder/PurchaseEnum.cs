
namespace BowenSerene.Default
{
    using Serenity.ComponentModel;
    using System.ComponentModel;

    [EnumKey("Purchase.Type")]
    public enum PurchaseType
    {
        [Description("荒料")]
        Stone = 0,
        [Description("板材")]
        Slab = 1
    }

    [EnumKey("Purchase.ShareType")]
    public enum PurchaseShareType
    {
        [Description("体积分摊")]
        VolumeShare = 1,
        [Description("重量分摊")]
        WeightShare = 2
    }

    [EnumKey("Purchase.PayWay")]
    public enum PurchasePayWay
    {
        [Description("信用证")]
        VolumeShare = 1,
        [Description("T/T")]
        WeightShare = 2
    }
}
