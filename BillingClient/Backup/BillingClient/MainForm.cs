using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BillingLibrary;


namespace BillingClient
{
    public partial class MainForm : Form
    {
        private DataGridForm DGF;
        private ViewClientsForm CVF;
        private ViewTariffForm VTF;
        private AddSimForm ASF;
        private AddTariffForm ATF;
        private ViewSimForm VSF;

        public MainForm()
        {
            InitializeComponent();
            DGF = new DataGridForm();
            DGF.MdiParent = this;
            DGF.Show();
            CVF = new ViewClientsForm();
            CVF.MdiParent = this;
            CVF.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientForm ACF = new AddClientForm();
            ACF.ShowDialog();
            if (ACF.DialogResult == DialogResult.OK)
            {
                if (DGF!=null)
                {
                    DGF.RefreshGrid();
                }
                if (CVF!=null)
                {
                    CVF.RefreshGrid();
                }
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ASF = new AddSimForm();
            ASF.Show();
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ATF = new AddTariffForm();
            ATF.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClientForm UCF = new UpdateClientForm();
            UCF.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewClientsForm CVF = new ViewClientsForm();
            CVF.MdiParent = this;
            CVF.Show();
        }

        private void tariffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VTF = new ViewTariffForm();
            VTF.MdiParent = this;
            VTF.Show();
        }

        private void simcardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VSF = new ViewSimForm();
            VSF.MdiParent = this;
            VSF.Show();
        }

        private void callHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCallHistoryForm CallForm = new ViewCallHistoryForm();
            CallForm.MdiParent = this;
            CallForm.Show();
        }

        private void makeACallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmulCallForm ECF = new EmulCallForm();
            ECF.MdiParent = this;
            ECF.Show();
        }

        private void makeAPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmulPayForm EPC = new EmulPayForm();
            EPC.MdiParent = this;
            EPC.Show();
        }
    }
}