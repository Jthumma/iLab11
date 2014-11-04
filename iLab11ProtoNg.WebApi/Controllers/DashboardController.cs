using System.Collections.Generic;
using System.Web.Mvc;
using iLab11ProtoNg.DomainServices;
using iLab11ProtoNg.Models;

namespace iLab11ProtoNg.Controllers
{
    public class DashboardController : Controller
    {
      
        public ActionResult GetPolicies()
        {
            var list = new List<PolicyModel>
            {
                new PolicyModel {PolicyId = 1, Product = "BAP", Number = "2345671", Mod = 0, Version = 0, EffDate = "01/01/2014"},
                new PolicyModel {PolicyId = 2, Product = "ABC", Number = "8723089", Mod = 0, Version = 1, EffDate = "03/20/2013"}
            };
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetClaims()
        {
            var claims = new List<ClaimsModel>
            {
                new ClaimsModel {ClaimId = 1, ClaimDesc = "first claim"},
                new ClaimsModel {ClaimId = 2, ClaimDesc = "Second claim"}
            };
            return Json(claims, JsonRequestBehavior.AllowGet);
        }
    }
}