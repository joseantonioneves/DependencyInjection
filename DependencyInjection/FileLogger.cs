using System;
using System.Configuration;
using System.IO;

namespace DependencyInjection
{
    public class FileLogger : IErrorLogger
    {
        public void LogMessage(Exception ex)
        {
            string folderPath = ConfigurationManager.AppSettings["ErrorFolder"];
            if (!(Directory.Exists(folderPath)))
            {
                Directory.CreateDirectory(folderPath);
            }
            FileStream objFileStrome = new FileStream(folderPath + "errlog.txt", FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter(objFileStrome);
            objStreamWriter.Write("Message: " + ex.Message);
            objStreamWriter.Write("StackTrace: " + ex.StackTrace);
            objStreamWriter.Write("Date/Time: " + DateTime.Now.ToString());
            objStreamWriter.Write("============================================");
            objStreamWriter.Close();
            objFileStrome.Close();
        }
    }
}

