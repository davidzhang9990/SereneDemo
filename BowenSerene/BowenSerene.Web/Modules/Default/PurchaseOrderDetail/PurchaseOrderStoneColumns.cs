
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
        [Width(100)]
        public Guid? ProductId { get; set; }
        [Width(80)]
        public String Category { get; set; }
        [Width(80)]
        public String Container { get; set; }
        [Width(80)]
        public String BlockNumber { get; set; }
        [Width(80)]
        public Int32 Length { get; set; }
        [Width(80)]
        public Int32 Width { get; set; }
        [Width(80)]
        public Int32 Height { get; set; }
        [Width(80)]
        public Decimal Thick { get; set; }
        [Width(80)]
        public Decimal Weight { get; set; }
        [Width(80)]
        public Decimal Volume { get; set; }
        [Width(60)]
        public String Mine { get; set; }
        [Width(60)]
        public String Grade { get; set; }
        [Width(120)]
        public String Notes { get; set; }
    }
}