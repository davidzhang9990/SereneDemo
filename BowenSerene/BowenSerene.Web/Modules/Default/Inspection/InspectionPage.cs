
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Inspection"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.InspectionRow))]
    public class InspectionController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Inspection/InspectionIndex.cshtml");
        }
    }
}