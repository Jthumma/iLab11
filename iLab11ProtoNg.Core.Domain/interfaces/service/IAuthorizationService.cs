using iLab11ProtoNg.Core.Domain.domain;

namespace iLab11ProtoNg.Core.Domain.interfaces.service
{
    public interface IAuthorizationService
    {
        User GetAuthorizedUser();
        void StoreAuthorizedUser(User user);
        User AuthorizeUser(bool siteMinderOnly);
    }
}