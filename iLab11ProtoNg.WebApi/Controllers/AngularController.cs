using System.Reflection;
using System.Web.Mvc;
using log4net;

namespace iLab11ProtoNg.Controllers
{
    public class AngularController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // GET: Angular
        public ActionResult Index()
        {
            Log.DebugFormat("Launching Angular app");
            return View();
        }
    }
}