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
    public partial class AddSimForm : Form
    {
        public AddSimForm()
        {
            InitializeComponent();
            clientListBindingSource.DataSource = ClientList.GetClientList();
            tariffListBindingSource.DataSource = TariffList.GetTariffList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sim S = new Sim();
                S.SimClientID = (int)simClientIDComboBox.SelectedValue;
                S.SimCode = int.Parse(simCodeTextBox.Text);
                S.SimPhoneNumber = int.Parse(simPhoneNumberTextBox.Text);
                S.TariffID = (int)tariffIDComboBox.SelectedValue;
                S.SimBill = 0;
                S.InsertSim();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}