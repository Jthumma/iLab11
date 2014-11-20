using System.Linq;
using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;

namespace com.gaic.insuredPortal.WebApi.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly IClaimsService _claimsService;
        private readonly INotificationService _notificationService;
        private readonly IPolicyService _policyService;

        public DashboardController(IPolicyService policyService, IClaimsService claimsService,
            INotificationService notificationService,
            IAuthorizationService authorizationService) : base(authorizationService)
        {
            _policyService = policyService;
            _claimsService = claimsService;
            _notificationService = notificationService;
        }

        public ActionResult GetPolicies()
        {
            return Json(_policyService.GetPolicies("6113963", LoggedInUser), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetClaims()
        {
            return Json(_claimsService.GetClaims(LoggedInUser).Where(x => x.Status == "Open").Take(3), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetNotifications()
        {
            return Json(_notificationService.GetNotifications(LoggedInUser), JsonRequestBehavior.AllowGet);
        }
    }
}