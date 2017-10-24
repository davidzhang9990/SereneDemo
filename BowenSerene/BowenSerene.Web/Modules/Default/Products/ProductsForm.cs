
namespace BowenSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Products")]
    [BasedOnRow(typeof(Entities.ProductsRow))]
    public class ProductsForm
    {
        [Tab("品目属性")]
        [Category("基本信息")]
        public String Number { get; set; }
        public String Name { get; set; }
        public Decimal Density { get; set; }
        public String Place { get; set; }
        public Int16 IsActive { get; set; }
        [Tab("品目属性")]
        [Category("图片附件")]
        public String Attach { get; set; }

    }
}