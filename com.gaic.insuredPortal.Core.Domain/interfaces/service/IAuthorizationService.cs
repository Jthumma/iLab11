using com.gaic.insuredPortal.Core.Domain.domain;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.service
{
    public interface IAuthorizationService
    {
        User GetAuthorizedUser();
        void StoreAuthorizedUser(User user);
        User AuthorizeUser(bool siteMinderOnly);
    }
}