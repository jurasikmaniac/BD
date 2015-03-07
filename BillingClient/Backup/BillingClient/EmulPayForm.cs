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
    public partial class EmulPayForm : Form
    {
        public EmulPayForm()
        {
            InitializeComponent();
        }
        public EmulPayForm(Sim _s)
        {
            InitializeComponent();
            textBox1.Text = _s.SimPhoneNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sim CurSim = new Sim();
            int p = int.Parse(textBox1.Text);
            bool k = false;
            foreach (Sim S in SimList.GetSimList(0))
            {
                if (S.SimPhoneNumber == p)
                {
                    k = true;
                }
            }
            if (k)
            {
                CurSim.MakePay(p, DateTime.Now, int.Parse(textBox2.Text));
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого номера не зарегестрировано.","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}