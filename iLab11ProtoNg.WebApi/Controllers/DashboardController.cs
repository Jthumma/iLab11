using System.Web.Mvc;
using iLab11ProtoNg.DomainServices;

namespace iLab11ProtoNg.Controllers
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