using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pb5
{
    class FileHelper
    {  /* returns the absolute path to the apk folder */
        public static String GetApkFolder()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "apk";
        }
        public static String GetD2JFolder()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "d2j";
        }
        public static String GetJGUIFolder()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "jdgui";
        }
        /* this method will clear everything that is in the /apk folder */
        public static void ClearApkFolder()
        {
            try
            {
                clearFolder(GetApkFolder());
                FileHelper.DeleteOldJarFile();
            }
            catch
            {
                
            }
        }
        public static void DeleteOldJarFile()
        {
            File.Delete(GetD2JFolder() + "/classes-dex2jar.jar");
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
