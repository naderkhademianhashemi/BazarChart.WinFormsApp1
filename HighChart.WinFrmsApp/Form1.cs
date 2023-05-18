using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighChart.WinFrmsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var appPath = Path.GetDirectoryName(Application.ExecutablePath).
                Replace(@"\bin\Debug", "");
            var Url =
                String.Format("file:///{0}/html/HighChart-EN.html", appPath);
            System.Diagnostics.Process.Start(Url);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Bazar Risk";
            linkLabel2.Text = "ریسک بازار";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var appPath = Path.GetDirectoryName(Application.ExecutablePath).
                Replace(@"\bin\Debug", "");
            var Url =
                String.Format("file:///{0}/html/HighChart.html", appPath);
            System.Diagnostics.Process.Start(Url);
        }
    }
}
