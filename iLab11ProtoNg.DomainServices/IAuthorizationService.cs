using iLab11ProtoNg.Core.Domain;

namespace iLab11ProtoNg.DomainServices
{
    public interface IAuthorizationService
    {
        User GetAuthorizedUser();
        void StoreAuthorizedUser(User user);
        bool AuthorizeUser(bool siteMinderOnly);
    }
}