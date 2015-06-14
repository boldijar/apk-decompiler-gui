using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 

namespace pb5
{
    public partial class Form1 : Form
    {


        private static  long MIN_BYTES_WARNING = 5000000;
        public Form1()
        {
            InitializeComponent();

            /* add the github url */
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/BoldijarPaul/apk-decompiler-gui";
            linkLabel1.Links.Add(link);
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            /* show a open file dialog */
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter="Apk Files (.apk)|*.apk|All Files (*.*)|*.*";
            if(openDialog.ShowDialog()==DialogResult.OK)
            {
                /* if we clicked open */
                LoadApk(openDialog.FileName);
            }
        }

        /* called when we want to load the apk */
        private void LoadApk(string path)
        {
            if (new FileInfo(path).Length > MIN_BYTES_WARNING)
            {
                MessageBox.Show("This file is over 5mb, so it might take some time to decompile");
            }
            ExtractHelper.ExtractApk(path);
            /* done extracting apk, now make the .jar file */
          
            CmdHelper.ExecuteCmd("d2j-dex2jar "+FileHelper.GetApkFolder()+"/classes.dex ",FileHelper.GetD2JFolder());
           
            /* now run the jar file*/
            String cmd = "jd-gui \"" + FileHelper.GetD2JFolder()  + "//classes-dex2jar.jar" + "\"";
            CmdHelper.ExecuteCmd(cmd, FileHelper.GetJGUIFolder());
      
        }

      
         


       

    }
}
