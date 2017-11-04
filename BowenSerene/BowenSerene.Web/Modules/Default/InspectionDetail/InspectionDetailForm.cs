
namespace BowenSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.InspectionDetail")]
    [BasedOnRow(typeof(Entities.InspectionDetailRow))]
    public class InspectionDetailForm
    {
        public Int32 ParentId { get; set; }
        public Int32 OrderDetailId { get; set; }
    }
}