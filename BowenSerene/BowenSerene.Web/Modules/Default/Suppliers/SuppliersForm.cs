
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace BowenSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Suppliers")]
    [BasedOnRow(typeof(Entities.SuppliersRow))]
    public class SuppliersForm
    {
        public String Number { get; set; }
        public String Name { get; set; }
      
        public String Suffix { get; set; }
        public String Country { get; set; }
        public String Place { get; set; }
        public Int16 IsActive { get; set; }
        [TextAreaEditor(Rows = 8, Cols = 10)]
        public String Notes { get; set; }
       
    }
}