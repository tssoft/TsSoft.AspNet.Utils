namespace TsSoft.AspNet.Utils.Services
{
    public interface IPasswordGenerator
    {
        string Generate(string password, string providerTypeName = "");
    }
}
