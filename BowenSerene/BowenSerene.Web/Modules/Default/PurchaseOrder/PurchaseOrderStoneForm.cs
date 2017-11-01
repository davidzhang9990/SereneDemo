

namespace BowenSerene.Default.Forms
{

    using Serenity.ComponentModel;
    using System.ComponentModel;
    using System.Collections.Generic;
    [FormScript("Default.PurchaseOrderStone")]
    [BasedOnRow(typeof(Entities.PurchaseOrderRow))]
    public class PurchaseOrderStoneForm : PurchaseOrderBaseForm
    {
        [Tab("采购信息")]
        [Category("采购明细")]
        [PurchaseOrderStoneEditor]
        public List<Entities.PurchaseOrderDetailRow> OrderDetailsList { get; set; }
    }
}