
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Products"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProductsRow))]
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Products/ProductsIndex.cshtml");
        }
    }
}