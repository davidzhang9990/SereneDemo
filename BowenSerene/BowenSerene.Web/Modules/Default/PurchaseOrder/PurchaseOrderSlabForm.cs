
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

    [FormScript("Default.PurchaseOrderSlab")]
    [BasedOnRow(typeof(Entities.PurchaseOrderRow))]
    public class PurchaseOrderSlabForm : PurchaseOrderBaseForm
    {
        [Tab("采购信息")]
        [Category("采购明细")]
        [PurchaseOrderSlabEditor]
        public List<Entities.PurchaseOrderDetailRow> OrderDetailsList { get; set; }
    }
}