
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Tenants"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TenantsRow))]
    public class TenantsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Tenants/TenantsIndex.cshtml");
        }
    }
}