using System;

namespace TsSoft.AspNet.Utils.Services
{
    internal class PasswordGenerator: IPasswordGenerator
    {
        private IPasswordGenerator _membershipProviderPasswordGenerator;
        private const string GeneratorsPostfix = "PasswordGenerator";

        public string Generate(string password, string providerTypeName)
        {
            if (string.IsNullOrEmpty(providerTypeName))
            {
                throw new ArgumentNullException("providerTypeName");
            }
            var generatorTypeName = string.Format("{0}.{1}{2}", typeof (PasswordGenerator).Namespace, providerTypeName,
                                                  GeneratorsPostfix);
            var generatorType = Type.GetType(generatorTypeName);
            if (generatorType == null)
            {
                throw new NotSupportedException("Provider with this type not supported");
            }
            _membershipProviderPasswordGenerator = (IPasswordGenerator) Activator.CreateInstance(generatorType);
            var result = _membershipProviderPasswordGenerator.Generate(password);
            return result;
        }
    }
}
