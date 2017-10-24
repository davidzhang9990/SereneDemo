
namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Products")]
    [BasedOnRow(typeof(Entities.ProductsRow))]
    public class ProductsColumns
    {
        [EditLink]
        public String Number { get; set; }
        public String Name { get; set; }
        public Decimal Density { get; set; }
        public String Place { get; set; }
        public Int16 IsActive { get; set; }
    }
}