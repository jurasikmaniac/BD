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
    public partial class ViewCallHistoryForm : Form
    {
        public ViewCallHistoryForm()
        {
            InitializeComponent();
            RefreshTree();
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView T = (TreeView)sender;

            if (T.SelectedNode.Level == 2)
            {
                callListDataGridView.DataSource = null;
                callListDataGridView.DataSource = CallList.GetCallList(int.Parse(T.SelectedNode.Name.ToString()));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < treeView1.Nodes[0].Nodes.Count; j++)
            {
                int i = 0;
                bool k = true;

                while ((i < textBox1.Text.Length) & (i < treeView1.Nodes[0].Nodes[j].Text.Length)&k)
                {
                    if (textBox1.Text[i]!=treeView1.Nodes[0].Nodes[j].Text[i])
                    {
                        k = false;
                    }
                    i++;
                }
                if (k)
                {
                    treeView1.SelectedNode = treeView1.Nodes[0].Nodes[j];
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < treeView1.Nodes[0].Nodes.Count; j++)
            {
                for (int g = 0; g < treeView1.Nodes[0].Nodes[j].Nodes.Count; g++)
                {
                    int i = 0;
                    bool k = true;

                    while ((i < textBox2.Text.Length) & (i < treeView1.Nodes[0].Nodes[j].Nodes[g].Text.Length) & k)
                    {
                        if (textBox2.Text[i] != treeView1.Nodes[0].Nodes[j].Nodes[g].Text[i])
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
    }
}