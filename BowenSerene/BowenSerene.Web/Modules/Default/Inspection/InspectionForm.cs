
using Serenity.Data.Mapping;

namespace BowenSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Inspection")]
    [BasedOnRow(typeof(Entities.InspectionRow))]
    public class InspectionForm
    {
        [Tab("采购信息")]
        [Category("基本信息")]
        [Hidden]
        public Guid ParentId { get; set; }
        [ReadOnly(true)]
        public Guid? ParentSupplierId { get; set; }
        [ReadOnly(true)]
        public String ParentNumber { get; set; }
        [ReadOnly(true)]
        public Int16? ParentType { get; set; }
        [ReadOnly(true)]
        public Int16? ParentShareType { get; set; }
        [DisplayName("制单人"), ReadOnly(true)]
        public string UserDisplayName { get; set; }
        [ReadOnly(true)]
        public DateTime? ParentPurchaseDate { get; set; }
        [TextAreaEditor(Rows = 3), ReadOnly(true)]
        public String ParentNotes { get; set; }
        public Int32 UserId { get; set; }
        [Tab("采购信息")]
        [Category("采购明细")]
        [InspectionStoneEditor]
        public List<Entities.InspectionDetailRow> OrderDetailsList { get; set; }
    }
}