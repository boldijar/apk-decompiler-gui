using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace pb5
{
    class CmdHelper
    {
        public static void ExecuteCmd(String cmd)
        {
            
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + cmd;
            Process process = Process.Start(startInfo);
            process.WaitForExit();  
           // process.Start();
        }
        public static void ExecuteCmd(String cmd, String workingDirectory)
        {
           
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = workingDirectory;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + cmd;
             
            Process process = Process.Start(startInfo);
            process.WaitForExit();  
         //   process.Start();
        }
    }
}
