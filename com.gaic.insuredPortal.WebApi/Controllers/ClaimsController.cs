using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;

namespace com.gaic.insuredPortal.WebApi.Controllers
{
    public class ClaimsController : BaseController
    {
        private readonly IClaimsService _claimsService;


        public ClaimsController(IClaimsService claimsService, IAuthorizationService authorizationService)
            : base(authorizationService)
        {
            _claimsService = claimsService;
        }

        public ActionResult GetClaims()
        {
            return Json(_claimsService.GetClaims(LoggedInUser), JsonRequestBehavior.AllowGet);
        }
    }
}