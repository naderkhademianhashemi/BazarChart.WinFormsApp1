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

namespace Chart.Browser.WindowsFormsApp1.FRM
{
    public partial class FrmLnkLbl : Form
    {
        public FrmLnkLbl()
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var appPath = Path.GetDirectoryName(Application.ExecutablePath).
                Replace(@"\bin\Debug", "");
            var Url =
                String.Format("file:///{0}/html/HighChart.html", appPath);
            System.Diagnostics.Process.Start(Url);
        }

        private void FrmLnkLbl_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Bazar Risk";
            linkLabel2.Text = "ریسک بازار";
            linkLabel3.Text = "csv";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var appPath = Path.GetDirectoryName(Application.ExecutablePath).
                Replace(@"\bin\Debug", "");
            var Url =
                String.Format("file:///{0}/html/HighChart-csv.html", appPath);
            System.Diagnostics.Process.Start(Url);
        }
    }
}
