using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 

namespace pb5
{
    public partial class Form1 : Form
    {
       


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
            ExtractHelper.ExtractApk(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileHelper.ClearApkFolder();
        }

         


       

    }
}
