
namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Suppliers")]
    [BasedOnRow(typeof(Entities.SuppliersRow))]
    public class SuppliersColumns
    {
        [EditLink]
        public String Number { get; set; }
        [EditLink]
        public String Name { get; set; }

        public String Suffix { get; set; }
        public String Country { get; set; }
        public String Place { get; set; }

        public Int16 IsActive { get; set; }

        public String Notes { get; set; }
    }
}