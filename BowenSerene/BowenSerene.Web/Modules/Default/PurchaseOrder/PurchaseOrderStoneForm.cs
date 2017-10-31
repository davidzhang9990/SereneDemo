
using MVC;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

namespace BowenSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.PurchaseOrderStone")]
    [BasedOnRow(typeof(Entities.PurchaseOrderRow))]
    public class PurchaseOrderStoneForm : PurchaseOrderBaseForm
    {
        [Tab("采购信息")]
        [Category("采购明细")]
        [PurchaseOrderStoneEditor]
        public List<Entities.PurchaseOrderDetailRow> OrderDetailsList { get; set; }
    }
}