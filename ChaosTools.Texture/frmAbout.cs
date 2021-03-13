using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace ChaosTools.Texture
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            lbVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void label2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("explorer", "https://github.com/5z3f");
    }
}
