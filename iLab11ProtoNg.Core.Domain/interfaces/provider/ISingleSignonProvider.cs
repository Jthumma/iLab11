namespace iLab11ProtoNg.Core.Domain.interfaces.provider
{
    public interface ISingleSignonProvider
    {
        string GetSingleSignonToken(string userName, string pwd);
    }
}