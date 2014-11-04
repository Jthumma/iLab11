using System.Collections.Generic;
using System.Web.Mvc;
using iLab11ProtoNg.Models;

namespace iLab11ProtoNg.Controllers
{
    public class PolicyController : Controller
    {
        public ActionResult GetPolicies()
        {
            var list = new List<PolicyModel>
            {
                new PolicyModel {PolicyId = 1, Product = "BAP", Number = "2345671", Mod = 0, Version = 0},
                new PolicyModel {PolicyId = 2, Product = "ABC", Number = "8723089", Mod = 0, Version = 1}
            };
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAgentInfo()
        {
            var agentInfo = new AgentModel {Name = "Agent Andy", AgencyName = "XYZ Agency", Address = new Address{Line1 = "234 Line1", City = "Colorado Spring", State = "CO", Zip = "45202"}};


            return Json(agentInfo, JsonRequestBehavior.AllowGet);
        }

    }
}