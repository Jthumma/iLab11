using System.Web.Mvc;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.WebApi.Controllers
{
    public class BaseController : Controller
    {
        private readonly IAuthorizationService _authorizationService;

        public BaseController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        protected UserModel LoggedInUser
        {
            get { return _authorizationService.GetAuthorizedUser(); }
        }
    }
}