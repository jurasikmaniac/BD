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
    public partial class AddClientForm : Form
    {
        public Client NewClient;

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool k = true;

            try
            {
                NewClient = new Client();
                NewClient.ClientName = clientNameTextBox.Text;
                NewClient.ClientEmail = clientEmailTextBox.Text;
                NewClient.ClientPasNumber = int.Parse(clientPasNumberTextBox.Text);
                NewClient.InsertClient();
                
            }
            catch (Exception)
            {
                k = false;
                MessageBox.Show("Проверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (k)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}