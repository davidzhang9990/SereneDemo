
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/PurchaseOrder"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PurchaseOrderRow))]
    public class PurchaseOrderController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/PurchaseOrder/PurchaseOrderIndex.cshtml");
        }

        public ActionResult CreateAssignOrderIndex()
        {
            return View("~/Modules/Default/PurchaseOrder/CreateAssignOrderIndex.cshtml");
        }
    }
}