


namespace BowenSerene.Default.Forms
{
    using Serenity.ComponentModel;
    using System.ComponentModel;
    using System.Collections.Generic;

    [FormScript("Default.PurchaseOrderSlab")]
    [BasedOnRow(typeof(Entities.PurchaseOrderRow))]
    public class PurchaseOrderSlabForm : PurchaseOrderBaseForm
    {
        [Tab("采购信息")]
        [Category("采购明细")]
        [PurchaseOrderSlabEditor]
        public List<Entities.PurchaseOrderDetailRow> OrderDetailsList { get; set; }
    }
}