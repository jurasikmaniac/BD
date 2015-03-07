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
    public partial class ViewTariffForm : Form
    {
        private TariffList TList;
        private TariffList CurTList;

        public ViewTariffForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            TList = new TariffList();
            CurTList = new TariffList();
            foreach (Tariff T in TariffList.GetTariffList())
            {
                TList.Add(T);
            }
            tariffListDataGridView.DataSource = null;
            tariffListDataGridView.DataSource = TList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTariffForm ATF = new AddTariffForm();
            ATF.ShowDialog();
            if (ATF.DialogResult == DialogResult.OK)
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
                if (MessageBox.Show("Вы действительно хотите удалить данный тариф?","Подтвердите удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                {
                    Tariff T = new Tariff();
                    T.TariffID = int.Parse(tariffListDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    T.DeleteTariff();
                    RefreshGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно удалить данный тариф", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ViewTariffForm_SizeChanged(object sender, EventArgs e)
        {
            tariffListDataGridView.Height = this.Height - 80;
        }

    }
}