
namespace BowenSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.ProductFinishType")]
    [BasedOnRow(typeof(Entities.ProductFinishTypeRow))]
    public class ProductFinishTypeForm
    {
        public String Name { get; set; }
        public Int16 IsActive { get; set; }
    }
}