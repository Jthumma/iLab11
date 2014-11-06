using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;

namespace com.gaic.insuredPortal.WebApi.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IClaimsService _claimsService;
        private readonly IPolicyService _policyService;

        public DashboardController(IPolicyService policyService, IClaimsService claimsService)
        {
            _policyService = policyService;
            _claimsService = claimsService;
        }

        public ActionResult GetPolicies()
        {
            return Json(_policyService.GetPolicies(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetClaims()
        {
            return Json(_claimsService.GetClaims(), JsonRequestBehavior.AllowGet);
        }
    }
}