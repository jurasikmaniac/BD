using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BillingLibrary;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;
using System.Data;

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
                if (C.ClientName.IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    CurList.Add(C);
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Client.GetClient(int.Parse(clientListDataGridView.SelectedRows[0].Cells[0].Value.ToString()))
            
            System.IO.FileStream fs = new FileStream(Application.StartupPath + "\\" + "ClientDetails_"+clientListDataGridView.SelectedRows[0].Cells[1].Value.ToString()+".pdf", FileMode.Create);

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);

            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner
            document.Add(new Paragraph("Call detail"));
            
            PdfPTable table = new PdfPTable(5);
            PdfPCell cell = new PdfPCell(new Phrase(clientListDataGridView.SelectedRows[0].Cells[1].Value.ToString()));
            cell.Colspan = 5;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);
            table.AddCell("Sim№");
            table.AddCell("Date");
            table.AddCell("Call lenght");
            table.AddCell("Call bill");
            table.AddCell("Target phone");            
            
            try
            {
                string _connection = "Data Source=ZIZA-GAME;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetClientCallList";
                    cm.Parameters.AddWithValue("@ClientID", int.Parse(clientListDataGridView.SelectedRows[0].Cells[0].Value.ToString()));
                    SqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {

                        table.AddCell(dr["SimPhoneNumber"].ToString());
                        table.AddCell(dr["CallDateTime"].ToString());
                        table.AddCell(dr["CallLength"].ToString());
                        table.AddCell(dr["CallPrice"].ToString());
                        table.AddCell(dr["CallPhoneNumber"].ToString());
                       
                    }
                }

            }
            catch (Exception)
            {

            }
            document.Add(table);
            // Close the document
            document.Close();
            // Close the writer instance
            writer.Close();
            // Always close open filehandles explicity
            fs.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new FileStream(Application.StartupPath + "\\"+"Debtors.pdf", FileMode.Create);

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);

            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner
            document.Add(new Paragraph("Debtors"));

            PdfPTable table = new PdfPTable(3);
            
            table.AddCell("Client name");
            table.AddCell("Sim phone");
            table.AddCell("Bill");          

            try
            {
                string _connection = "Data Source=ZIZA-GAME;Initial Catalog=BillingDB;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(_connection))
                {
                    cn.Open();
                    SqlCommand cm = cn.CreateCommand();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetDebtorList";                    
                    SqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {

                        table.AddCell(dr["ClientName"].ToString());
                        table.AddCell(dr["SimPhoneNumber"].ToString());
                        table.AddCell(dr["SimBill"].ToString());

                    }
                }

            }
            catch (Exception)
            {

            }
            document.Add(table);
            document.Add(new Paragraph("Please send this file to killer."));
            // Close the document
            document.Close();
            // Close the writer instance
            writer.Close();
            // Always close open filehandles explicity
            fs.Close();
        }
    }
}