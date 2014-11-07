using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.service
{
    public interface IAuthorizationService
    {
        UserModel GetAuthorizedUser();
        void StoreAuthorizedUser(UserModel userModel);
        UserModel AuthorizeUser(bool siteMinderOnly);
    }
}