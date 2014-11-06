using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.domain;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using log4net;

namespace com.gaic.insuredPortal.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly ILog _log;


        public HomeController(IAuthorizationService authorizationService, ILog log)
        {
            _authorizationService = authorizationService;
            _log = log;
        }

        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";

            //return View();

            _log.DebugFormat("Verify previoulsy authenticated");
            User user = _authorizationService.GetAuthorizedUser();

            if (user == null)
            {
                _log.DebugFormat("Redirecting to LoginLocal");
                return RedirectToAction("Login", "Authentication");
            }

            _log.DebugFormat("Authentication successful for user {0} from IPAddress {1} ", user.UserId, user.IpAddress);
            _log.DebugFormat("StoreAuthorizedUser {0} ", user.UserId);
            _authorizationService.StoreAuthorizedUser(user);

            _log.DebugFormat("Redirecting to Flex App");
            return RedirectToAction("Index", "Angular");
        }
    }
}