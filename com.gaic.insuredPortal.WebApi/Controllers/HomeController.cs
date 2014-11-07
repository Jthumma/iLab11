using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;
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
            UserModel userModel = _authorizationService.GetAuthorizedUser();

            if (userModel == null)
            {
                _log.DebugFormat("Redirecting to LoginLocal");
                return RedirectToAction("Login", "Authentication");
            }

            _log.DebugFormat("Authentication successful for user {0} from IPAddress {1} ", userModel.UserId, userModel.IpAddress);
            _log.DebugFormat("StoreAuthorizedUser {0} ", userModel.UserId);
            _authorizationService.StoreAuthorizedUser(userModel);

            _log.DebugFormat("Redirecting to Flex App");
            return RedirectToAction("Index", "Angular");
        }
    }
}