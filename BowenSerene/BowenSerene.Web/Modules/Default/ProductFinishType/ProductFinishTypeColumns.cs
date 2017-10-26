
namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.ProductFinishType")]
    [BasedOnRow(typeof(Entities.ProductFinishTypeRow))]
    public class ProductFinishTypeColumns
    {
        [EditLink]
        public String Name { get; set; }
        public Int32 SortCode { get; set; }
        public Int16 IsActive { get; set; }
        [DisplayName("创建日期"),Width(120)]
        public DateTime InsertDate { get; set; }
    }
}