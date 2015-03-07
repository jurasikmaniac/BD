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
    public partial class EmulCallForm : Form
    {
        private bool talking;
        private DateTime Begin;
        private DateTime End;

        public EmulCallForm()
        {
            InitializeComponent();
            RefreshTree();
            talking = false;
        }
        public EmulCallForm(Sim _s)
        {
            InitializeComponent();
            RefreshTree();
            talking = false;
            string S = _s.SimCode.ToString();
            for (int j = 0; j < treeView1.Nodes[0].Nodes.Count; j++)
            {
                for (int g = 0; g < treeView1.Nodes[0].Nodes[j].Nodes.Count; g++)
                {
                    int i = 0;
                    bool k = true;

                    while ((i < S.Length) & (i < treeView1.Nodes[0].Nodes[j].Nodes[g].Text.Length) & k)
                    {
                        if (S[i] != treeView1.Nodes[0].Nodes[j].Nodes[g].Text[i])
                        {
                            k = false;
                        }
                        i++;
                    }
                    if (k)
                    {
                        treeView1.SelectedNode = treeView1.Nodes[0].Nodes[j].Nodes[g];
                    }
                }
            }
        }
        public void RefreshTree()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Клиенты");
            foreach (Client C in ClientList.GetClientList())
            {
                treeView1.Nodes[0].Nodes.Add(C.ClientName.ToString());
                treeView1.Nodes[0].LastNode.Name = C.ClientID.ToString();

                foreach (Sim S in SimList.GetSimList(C.ClientID))
                {
                    treeView1.Nodes[0].LastNode.Nodes.Add(S.SimPhoneNumber.ToString());
                    treeView1.Nodes[0].LastNode.LastNode.Name = S.SimID.ToString();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((treeView1.SelectedNode.Level == 2) & (int.Parse(textBox1.Text) != 0))
                {
                    if (!talking)
                    {
                        treeView1.Enabled = false;
                        textBox1.Enabled = false;
                        Begin = new DateTime();
                        Begin = DateTime.Now;
                        button1.Text = "Stop";
                        talking = true;
                    }
                    else
                        if (talking)
                        {
                            treeView1.Enabled = true;
                            textBox1.Enabled = true;
                            End = new DateTime();
                            End = DateTime.Now;
                            button1.Text = "Call";
                            talking = false;
                            int c = (End.Minute * 60 + End.Second) - (Begin.Minute * 60 + Begin.Second);
                            Sim S = new Sim();
                            S.SimID = int.Parse(treeView1.SelectedNode.Name);
                            S.MakeCall(c, false, int.Parse(textBox1.Text), Begin);
                            label2.Text = "Длительность вызова - " + c.ToString() + " сек.";
                        }
                }
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