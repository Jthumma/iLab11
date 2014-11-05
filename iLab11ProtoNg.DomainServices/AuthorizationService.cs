using iLab11ProtoNg.Core.Domain;

namespace iLab11ProtoNg.DomainServices
{
    public class AuthorizationService : IAuthorizationService
    {
        public User GetAuthorizedUser()
        {
            return new User(){UserId = "taccount1"};
        }

        public void StoreAuthorizedUser(User user)
        {
            
        }

        public bool AuthorizeUser(bool siteMinderOnly)
        {
            var user = GetAuthorizedUser();
            return user != null;
        }
    }
}