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
    public partial class ViewSimForm : Form
    {
        private SimList SList;
        private SimList CurSList;

        public ViewSimForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            SList = new SimList();
            CurSList = new SimList();
            foreach (Sim S in SimList.GetSimList(0))
            {
                SList.Add(S);
            }
            simListDataGridView.DataSource = null;
            simListDataGridView.DataSource = SList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSimForm ASF = new AddSimForm();
            ASF.ShowDialog();
            if (ASF.DialogResult == DialogResult.OK)
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
                if (MessageBox.Show("Вы действительно хотите удалить все данные этой симки?", "Подтвердите удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Sim S = new Sim();
                    S.SimID = int.Parse(simListDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    S.DeleteSim();
                    RefreshGrid();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Невозможно удалить данную симку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewSimForm_SizeChanged(object sender, EventArgs e)
        {
            simListDataGridView.Height = this.Height - 80;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sim S = new Sim();
            S.SimID = int.Parse(simListDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            UpdateSimForm USF = new UpdateSimForm(S);
            USF.ShowDialog();
            if (USF.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmulCallForm EMCF = new EmulCallForm(Sim.GetSim(int.Parse(simListDataGridView.SelectedRows[0].Cells[0].Value.ToString())));
            EMCF.ShowDialog();
            if (EMCF.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmulPayForm EMPF = new EmulPayForm(Sim.GetSim(int.Parse(simListDataGridView.SelectedRows[0].Cells[0].Value.ToString())));
            EMPF.ShowDialog();
            if (EMPF.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

    }
}