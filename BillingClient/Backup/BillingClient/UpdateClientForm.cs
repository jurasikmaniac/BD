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
    public partial class UpdateClientForm : Form
    {
        private Client C;

        public UpdateClientForm()
        {
            C = new Client();
            InitializeComponent();
            clientEditBindingSource.DataSource = ClientList.GetClientList();
        }

        public UpdateClientForm(Client _c)
        {
            C = new Client();
            InitializeComponent();
            clientEditBindingSource.DataSource = ClientList.GetClientList();
            clientIDComboBox.SelectedValue = _c.ClientID;   
        }

        private void clientIDComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (clientIDComboBox.SelectedValue != null)
            {
                int x = (int)clientIDComboBox.SelectedValue;
                clientNameTextBox.Text = Client.GetClient(x).ClientName;
                clientPasNumberTextBox.Text = Client.GetClient(x).ClientPasNumber.ToString();
                clientEmailTextBox.Text = Client.GetClient(x).ClientEmail;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                C.ClientID = (int)clientIDComboBox.SelectedValue;
                C.ClientName = clientNameTextBox.Text;
                C.ClientPasNumber = int.Parse(clientPasNumberTextBox.Text);
                C.ClientEmail = clientEmailTextBox.Text;

                C.UpdateClient();
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}