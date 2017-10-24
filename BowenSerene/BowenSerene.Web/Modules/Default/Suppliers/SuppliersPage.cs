
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Suppliers"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.SuppliersRow))]
    public class SuppliersController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Suppliers/SuppliersIndex.cshtml");
        }
    }
}