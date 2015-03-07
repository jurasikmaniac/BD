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
    public partial class DataGridForm : Form
    {
        public DataGridForm()
        {
            InitializeComponent();
            RefreshGrid();

        }

        public void RefreshGrid()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Clients");
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
            if (T.SelectedNode.Level == 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ClientList.GetClientList();
            }
            else
            {
                if (T.SelectedNode.Level == 1)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = SimList.GetSimList(int.Parse(T.SelectedNode.Name));
                }
            }
        }
    }
}