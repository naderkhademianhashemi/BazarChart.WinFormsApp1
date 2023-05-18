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
    public partial class FrmWeb : Form
    {
        public FrmWeb()
        {
            InitializeComponent();
        }

        private void FrmWeb_Load(object sender, EventArgs e)
        {
            var appPath = Path.GetDirectoryName(Application.ExecutablePath).
                Replace(@"\bin\Debug", "");
            var Url =
                String.Format("file:///{0}/html/HighChart-EN.html", appPath);
            webBrowser1.Url = new Uri(Url);
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
