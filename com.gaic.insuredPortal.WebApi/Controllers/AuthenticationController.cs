using System;
using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;
using log4net;

namespace com.gaic.insuredPortal.WebApi.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly ILog _log;

        public AuthenticationController(IAuthorizationService authorizationService, ILog log)
        {
            _authorizationService = authorizationService;
            _log = log;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //do not reformat the USER and PASSWORD case-sensitivity. These map to html name attributes on the view
        public ActionResult Login(string USER, string PASSWORD)
        {
            _log.DebugFormat("Requesting authentication for {0}", USER);

            UserModel userModel = _authorizationService.AuthorizeUser(false);
            if (userModel == null)
            {
                _log.DebugFormat("Authentication for {0} failed", USER);
                ViewBag.AuthenticationMessage = String.Format("Authentication for {0} failed", USER);
                return View();
            }

            _log.DebugFormat("Authentication for {0} succeeded", USER);


            //_log.DebugFormat("Redirecting to Home");
            //return RedirectToAction("Index", "Home");

            _log.DebugFormat("Redirecting to Angular App");
            return RedirectToAction("Index", "Angular");

            //_log.DebugFormat("Redirecting to Flex App");
            //return RedirectToAction("Index", "Flex");
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Authentication");
        }

        public ActionResult Register()
        {
            return View();
        }


        public ActionResult GetAuthorizedUser()
        {
            return Json(_authorizationService.GetAuthorizedUser(), JsonRequestBehavior.AllowGet);
        }

    }
}