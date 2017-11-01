
namespace BowenSerene.Default.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    public class PurchaseOrderBaseForm
    {
        [Tab("基本信息")]
        [Category("采购信息")]
        public String Number { get; set; }
        public DateTime PurchaseDate { get; set; }
        [ReadOnly(true)]
        public Int16 Type { get; set; }
        public Int16 ShareType { get; set; }
        public Guid SupplierId { get; set; }
        public Int16 PayWay { get; set; }
        [TextAreaEditor(Rows = 3)]
        public String Notes { get; set; }
        [Tab("运货信息")]
        [Category("船运")]
        public String LetterNumber { get; set; }
        public String AgentNumber { get; set; }
        public String Behalf { get; set; }
        public String BillLadingNumber { get; set; }
        public DateTime BillLadingDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public String CompanyShip { get; set; }
        public String PortDepart { get; set; }
        public String PortDest { get; set; }
        public String PriceTerms { get; set; }

        [Tab("运货信息")]
        [Category("附件")]
        public String Attachment { get; set; }

    }
}