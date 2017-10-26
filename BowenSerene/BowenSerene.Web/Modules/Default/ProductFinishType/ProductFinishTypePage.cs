
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/ProductFinishType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProductFinishTypeRow))]
    public class ProductFinishTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/ProductFinishType/ProductFinishTypeIndex.cshtml");
        }
    }
}