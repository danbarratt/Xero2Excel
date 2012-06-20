using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Xero2Excel.Core.Config
{
    public class ApplicationSettings
    {

        public X509Certificate2 OAuthSigningCertificate
        {
            get 
            {
                DirectoryInfo currentDirInfo = new DirectoryInfo(Environment.CurrentDirectory);

                Debug.WriteLine("Current Dir is:" + currentDirInfo.FullName);

                var pfxFiles = currentDirInfo.GetFiles("*.pfx");

                foreach (var pfxFile in pfxFiles)
                {
                    Debug.WriteLine(pfxFile.FullName);
                }

                return null;
            }
        }

    }
}
