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
    public partial class UpdateSimForm : Form
    {
        private Sim S;
        public UpdateSimForm()
        {
            InitializeComponent();
            simEditBindingSource.DataSource = SimList.GetSimList(0);
            tariffNameBindingSource.DataSource = TariffList.GetTariffList();
            clientNameBindingSource.DataSource = ClientList.GetClientList();
        }
        public UpdateSimForm(Sim _s)
        {
            InitializeComponent();
            simEditBindingSource.DataSource = SimList.GetSimList(0);
            tariffNameBindingSource.DataSource = TariffList.GetTariffList();
            clientNameBindingSource.DataSource = ClientList.GetClientList();
            simIDComboBox.SelectedValue = _s.SimID;
            simBindingSource.DataSource = _s;
        }

        private void simIDComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (simIDComboBox.SelectedValue != null)
            {
                simBindingSource.DataSource = Sim.GetSim((int)simIDComboBox.SelectedValue);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S = new Sim();
            try
            {
                S.SimID = (int)simIDComboBox.SelectedValue;
                S.SimClientID = int.Parse(simClientIDComboBox.SelectedValue.ToString());
                S.TariffID = int.Parse(tariffIDComboBox.SelectedValue.ToString());

                S.UpdateSim();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

    }
}