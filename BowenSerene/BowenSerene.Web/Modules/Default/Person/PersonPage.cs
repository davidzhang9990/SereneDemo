
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Person"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PersonRow))]
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Person/PersonIndex.cshtml");
        }
    }
}