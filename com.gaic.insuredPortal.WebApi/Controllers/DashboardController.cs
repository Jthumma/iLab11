using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;

namespace com.gaic.insuredPortal.WebApi.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly IClaimsService _claimsService;
        private readonly IPolicyService _policyService;

        public DashboardController(IPolicyService policyService, IClaimsService claimsService,
            IAuthorizationService authorizationService) : base(authorizationService)
        {
            _policyService = policyService;
            _claimsService = claimsService;
        }

        public ActionResult GetPolicies()
        {
            return Json(_policyService.GetPolicies("0000000", LoggedInUser.Token), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetClaims()
        {
            return Json(_claimsService.GetClaims(), JsonRequestBehavior.AllowGet);
        }
    }
}