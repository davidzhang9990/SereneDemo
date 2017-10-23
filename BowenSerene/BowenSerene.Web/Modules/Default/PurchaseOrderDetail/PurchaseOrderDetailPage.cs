
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/PurchaseOrderDetail"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PurchaseOrderDetailRow))]
    public class PurchaseOrderDetailController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/PurchaseOrderDetail/PurchaseOrderDetailIndex.cshtml");
        }
    }
}