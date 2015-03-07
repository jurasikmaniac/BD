using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BillingLibrary;

namespace BillingClient
{
    public partial class AddTariffForm : Form
    {
        public AddTariffForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tariff T = new Tariff();
                T.TariffName = tariffNameTextBox.Text;
                T.TariffSecCost = int.Parse(tariffSecCostTextBox.Text);
                T.InsertTariff();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте вводимые данные.","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}