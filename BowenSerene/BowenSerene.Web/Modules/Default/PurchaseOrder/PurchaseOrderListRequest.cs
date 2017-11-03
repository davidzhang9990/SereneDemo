using System;
using Serenity.Services;

namespace BowenSerene.Default
{
    public class PurchaseOrderListRequest : ListRequest
    {
        public Guid? ProductId { get; set; }

        public String Container { get; set; }

        public Int32? IsAssign { get; set; }
    }
}