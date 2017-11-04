
namespace BowenSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/InspectionDetail"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.InspectionDetailRow))]
    public class InspectionDetailController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/InspectionDetail/InspectionDetailIndex.cshtml");
        }
    }
}