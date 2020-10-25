using System;

namespace Joint.Secrets.Vault.Exceptions
{
    internal sealed class VaultAuthTypeNotSupportedException : Exception
    {
        public string AuthType { get; set; }

        public VaultAuthTypeNotSupportedException(string authType) : this(string.Empty, authType)
        {
        }

        public VaultAuthTypeNotSupportedException(string message, string authType) : base(message) 
            => AuthType = authType;
    }
}