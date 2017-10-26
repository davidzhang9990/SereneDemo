
namespace BowenSerene.Default
{
    using Serenity.Services;

    public class ProductListRequest : ServiceRequest
    {
        public string SupplierId { get; set; }
    }
}