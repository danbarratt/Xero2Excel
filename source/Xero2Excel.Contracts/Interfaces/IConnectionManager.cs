using System;

namespace Xero2Excel.Contracts.Interfaces
{
    public interface IConnectionManager
    {
        bool VerifyConnection();
        Uri InitialiseConnection();
        void FinaliseConnection(string oauthVerifier);
        void ResetConnection();
        CurrentConnectionDetails GetCurrentConnectionDetails();
    }
}
