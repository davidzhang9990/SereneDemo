
using System.Web.UI.WebControls;

namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.PurchaseOrderStone")]
    [BasedOnRow(typeof(Entities.PurchaseOrderDetailRow))]
    public class PurchaseOrderStoneColumns
    {

        [Width(120)]
        public Guid? ProductId { get; set; }
        [Width(120)]
        public String Category { get; set; }
        [Width(120)]
        public String Container { get; set; }
        [Width(120)]
        public String BlockNumber { get; set; }

        public Int32 Length { get; set; }
  
        public Int32 Width { get; set; }

        public Int32 Height { get; set; }
  
        public Decimal Weight { get; set; }
  
        public Decimal Volume { get; set; }

        public String Mine { get; set; }

        public String Grade { get; set; }

        public String Notes { get; set; }
    }
}