using System.Web.Mvc;
using iLab11ProtoNg.Core.Domain.interfaces.service;
using iLab11ProtoNg.DomainServices;

namespace iLab11ProtoNg.Controllers
{
    public class PolicyController : Controller
    {
        private readonly IAgentService _agentService;
        private readonly IPolicyService _policyService;

        public PolicyController(IPolicyService policyService, IAgentService agentService)
        {
            _policyService = policyService;
            _agentService = agentService;
        }

        public ActionResult GetPolicies()
        {
            return Json(_policyService.GetPolicies(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAgentInfo()
        {
            return Json(_agentService.GetAgentInfo(), JsonRequestBehavior.AllowGet);
        }
    }
}