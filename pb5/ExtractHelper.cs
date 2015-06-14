using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pb5
{
    class ExtractHelper
    {   
      
        public static void ExtractApk(String apkPath)
        {

            FileHelper.ClearApkFolder();
            string zipPath = apkPath;
            string extractPath = FileHelper.GetApkFolder();
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
