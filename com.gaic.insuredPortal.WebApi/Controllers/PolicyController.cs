using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;

namespace com.gaic.insuredPortal.WebApi.Controllers
{
    public class PolicyController : BaseController
    {
        private readonly IAgentService _agentService;
        private readonly IPolicyService _policyService;

        public PolicyController(IPolicyService policyService, IAgentService agentService,
            IAuthorizationService authorizationService) : base(authorizationService)
        {
            _policyService = policyService;
            _agentService = agentService;
        }

        public ActionResult GetPolicies()
        {
            return Json(_policyService.GetPolicies("0000000", LoggedInUser), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAgentInfo()
        {
            return Json(_agentService.GetAgentInfo(), JsonRequestBehavior.AllowGet);
        }
    }
}