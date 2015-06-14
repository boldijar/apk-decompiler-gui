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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


       

    }
}
