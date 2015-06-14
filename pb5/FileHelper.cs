using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb5
{
    class FileHelper
    {  /* returns the absolute path to the apk folder */
        public static String GetApkFolder()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "/apk";
        }
        /* this method will clear everything that is in the /apk folder */
        public static void ClearApkFolder()
        {
            try
            {
                clearFolder(GetApkFolder());
            }
            catch
            {

            }
        }
        private static void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }
   
    }
}
