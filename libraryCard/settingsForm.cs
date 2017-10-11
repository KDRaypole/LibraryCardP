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
    public partial class settingsForm : MetroFramework.Forms.MetroForm
    {

        private mainMenuForm mainForm = null;
        public settingsForm(MetroFramework.Forms.MetroForm callingForm)
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

        private void settingsTree_AfterSelect (object sender, TreeViewEventArgs e)
        {

            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();

            switch (settingsTree.SelectedNode.Name)
            {
                case "preferenceTab":
                case "comboBoxDefaults":
                    comboboxDefaultsPanel.Show();
                    break;
                case "overdueOptions":
                    overdueOptionsPanel.Show();
                    break;
            }
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            settingsTree.ExpandAll();
            this.comboBookVsDvd_sett.SelectedIndex = Properties.Settings.Default.addChoice;
            this.comboBookVsDvd_sett_edit.SelectedIndex = Properties.Settings.Default.editChoice;
            this.comboBoxID_ISBN_sett.SelectedIndex = Properties.Settings.Default.checkOutChoice;
            this.comboBoxCheckIn_sett.SelectedIndex = Properties.Settings.Default.checkInChoice;
            this.untilOverdue_sett.Value = Convert.ToDecimal(Properties.Settings.Default.daysUntilOverdue);
            this.overdueBookCost_sett.Value = Properties.Settings.Default.overdueBookCostPerDay;
            this.overdueDvdCost_sett.Value = Properties.Settings.Default.overdueDvdCostPerDay;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.addChoice = comboBookVsDvd_sett.SelectedIndex;
            Properties.Settings.Default.editChoice = comboBookVsDvd_sett_edit.SelectedIndex;
            Properties.Settings.Default.checkOutChoice = comboBoxID_ISBN_sett.SelectedIndex;
            Properties.Settings.Default.checkInChoice = comboBoxCheckIn_sett.SelectedIndex;
            Properties.Settings.Default.daysUntilOverdue = Convert.ToInt32(untilOverdue_sett.Value);
            Properties.Settings.Default.overdueBookCostPerDay = overdueBookCost_sett.Value;
            Properties.Settings.Default.overdueDvdCostPerDay = overdueDvdCost_sett.Value;

            MessageBox.Show("Settings Saved");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
