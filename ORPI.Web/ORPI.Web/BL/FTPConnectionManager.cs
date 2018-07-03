using System;
using System.IO;
using System.Net;
using System.Text;
using System.IO.Compression;
using static System.Net.Mime.MediaTypeNames;
using ORPI.Web.BL.Const;
using System.Threading;

namespace ORPI.Web.BL
{
    public class FTPConnectionManager
    {
        private Object lockObj = new Object();

        public FTPConnectionManager(string urlToZipFile, String zipFile)
        {
            // Get the object used to communicate with the server.  
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(urlToZipFile);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.  
            request.Credentials = new NetworkCredential("HASITATION050207", "050207HASITATION");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            
            DownloadFile(response.ResponseUri.AbsoluteUri, zipFile);
            //Decompress("C:/Users/Rumpel/source/repos/ConsoleApp2/ConsoleApp2/bin/Debug/result.zip"); //use another path
            Decompress(PathConst.SOURCE, zipFile);

            response.Close();
        }

        private void DownloadFile(string url, String zipFile)
        {
            //string myStringWebResource = null;
            WebClient myWebClient = new WebClient();
            myWebClient.Credentials = new NetworkCredential("HASITATION050207", "050207HASITATION");
            //myStringWebResource = url;
            myWebClient.DownloadFile(url, zipFile);

            //Decompress(response.ResponseUri.AbsoluteUri);
        }

        private void Decompress(String url, String zipFile)
        {
            Thread.Sleep(50000);
            //this._txtFilePath = @"C:\Users\Rumpel\Desktop\1";//use another path
            //ZipFile.ExtractToDirectory(url, @"C:\Users\Rumpel\Desktop\1"); //use another path
            ZipFile.ExtractToDirectory($"{url}{zipFile}", PathConst.TXTFILEPATH);
            Thread.Sleep(500000);
        }
    }
}
