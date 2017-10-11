using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryCard
{
    public partial class about : MetroFramework.Forms.MetroForm
    {
        private mainMenuForm mainForm = null;
        public about(MetroFramework.Forms.MetroForm callingForm)
        {
            mainForm = callingForm as mainMenuForm;
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.mainForm.Focus();
            this.mainForm.menuStrip1.Focus();

        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://teh.ddns.net/LibraryCard/");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to visit webpage.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
