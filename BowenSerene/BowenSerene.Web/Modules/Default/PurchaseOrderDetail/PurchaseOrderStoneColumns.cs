
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

        public Guid? ProductId { get; set; }
        [Hidden]
        public String ProductName { get; set; }

        public String Category { get; set; }

        public String Container { get; set; }

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