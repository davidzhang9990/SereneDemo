
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

    [ColumnsScript("Default.InspectionStone")]
    [BasedOnRow(typeof(Entities.InspectionDetailRow))]
    public class InspectionStoneColumns
    {
        [Width(120)]
        public String ProductName { get; set; }
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
        [Width(120)]
        public String Mine { get; set; }
        [Width(120)]
        public String Grade { get; set; }

        public String Notes { get; set; }
        [Hidden]
        public Int32? IsAssign { get; set; }
    }
}