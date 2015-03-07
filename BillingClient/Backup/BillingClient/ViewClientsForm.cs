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
    public partial class ViewClientsForm : Form
    {
        private List<Client> CList;
        private List<Client> CurList;

        public void RefreshGrid()
        {
            CurList = new List<Client>();
            CList = new List<Client>();
            foreach (Client C in ClientList.GetClientList())
            {
                CList.Add(C);
            }
            clientListDataGridView.DataSource = null;
            clientListDataGridView.DataSource = CList;
        }

        public ViewClientsForm()
        {
            InitializeComponent();
            RefreshGrid();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CurList.Clear();
            foreach (Client C in CList)
            {
                bool k = true;
                int i = 0;
                if (C.ClientName.Length >= textBox1.Text.Length)
                {
                    while ((i < C.ClientName.Length) & (i < textBox1.Text.Length) & k)
                    {
                        if (C.ClientName[i] != textBox1.Text[i])
                        {
                            k = false;
                        }
                        i++;
                    }
                    if (k)
                    {
                        CurList.Add(C);
                    }
                }
            }
            clientListDataGridView.DataSource = null;
            clientListDataGridView.DataSource = CurList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClientForm ACF = new AddClientForm();
            ACF.ShowDialog();
            if (ACF.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить все данные этого клиента?", "Подтвердите удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Client C = new Client();
                    C.ClientID = int.Parse(clientListDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    C.DeleteClient();
                    RefreshGrid();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Невозможно удалить данного клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ClientsViewForm_SizeChanged(object sender, EventArgs e)
        {
            clientListDataGridView.Height = this.Height - 80;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateClientForm UCF = new UpdateClientForm(Client.GetClient(int.Parse(clientListDataGridView.SelectedRows[0].Cells[0].Value.ToString())));
            UCF.ShowDialog();
            if (UCF.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }
    }
}