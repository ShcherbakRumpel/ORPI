﻿using System;
using System.IO;
using System.Net;
using System.Text;
using System.IO.Compression;
using static System.Net.Mime.MediaTypeNames;

namespace ORPI.Web.BL
{
    public class FTPConnectionManager
    {
        private FtpWebRequest request;
        private string _txtFilePath;

        public String GetFileByPath
        {
            get
            {
                return _txtFilePath;
            }
        }
        FTPConnectionManager(string UrlToZipFile)
        {
            // Get the object used to communicate with the server.  
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(UrlToZipFile);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.  
            request.Credentials = new NetworkCredential("HASITATION050207", "050207HASITATION");
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            DownloadFile(response.ResponseUri.AbsoluteUri);
            Decompress("C:/Users/Rumpel/source/repos/ConsoleApp2/ConsoleApp2/bin/Debug/result.zip"); //use another path


            response.Close();
            Console.ReadLine();
        }

        private void DownloadFile(string url)
        {
            string myStringWebResource = null;

            WebClient myWebClient = new WebClient();
            myWebClient.Credentials = new NetworkCredential("HASITATION050207", "050207HASITATION");
            myStringWebResource = url;
            myWebClient.DownloadFile(myStringWebResource, "result.zip");
            //Decompress(response.ResponseUri.AbsoluteUri);

        }
        private void Decompress(String url)
        {

            ZipFile.ExtractToDirectory(url, @"C:\Users\Rumpel\Desktop\1"); //use another path

            this._txtFilePath = @"C:\Users\Rumpel\Desktop\1";//use another path
        }
    }
}