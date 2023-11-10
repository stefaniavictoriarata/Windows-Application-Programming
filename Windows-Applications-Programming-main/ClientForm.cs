using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class ClientForm : Form
    {
       private readonly ClientContext clientContext;
        
        public ClientForm(ClientContext clientContext)
        {
            InitializeComponent();
            ClientForm_Load(null,EventArgs.Empty);
            this.clientContext = clientContext;
            AddClientsToDataView();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // Add columns to the DataGridView
            dataGridView1.Columns.Add("ClientIdColumn", "Client ID");
            dataGridView1.Columns.Add("ExtraOptionIdColumn", "Extra Option ID");
            dataGridView1.Columns.Add("SubcriptionIdColumn", "Subscription ID");
            dataGridView1.Columns.Add("ClientNameColumn", "Name");
            dataGridView1.Columns.Add("PhoneNumberColumn", "Phone number");


            // Optional: Set column properties such as width, alignment, etc.
            dataGridView1.Columns["ClientIdColumn"].Width = 100;
            dataGridView1.Columns["ExtraOptionIdColumn"].Width = 100;
            dataGridView1.Columns["SubcriptionIdColumn"].Width = 100;
            dataGridView1.Columns["ClientNameColumn"].Width = 100;
            dataGridView1.Columns["PhoneNumberColumn"].Width = 100;

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ClientContext context = new ClientContext();
            AddClient addClient = new AddClient(context);
            addClient.ShowDialog();
        }

       

        public void AddClientsToDataView()
        {

            List<Client> clients = clientContext.Clients.ToList(); 
            foreach (Client client in clients)
            {
                dataGridView1.Rows.Add(client.ClientId, client.ExtraOptionId, 
                    client.SubscriptionId, client.ClientName,client.PhoneNumber);
            }

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        public void ExportDataGridViewToTextFile(DataGridView dataGridView, string filePath)
        {
            // Create a new instance of StreamWriter to write to the text file
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the column headers
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    writer.Write(column.HeaderText + "\t");
                }
                writer.WriteLine();

                // Write the cell values for each row in the DataGridView
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        writer.Write(cell.Value + "\t");
                    }
                    writer.WriteLine();
                }
            }

            // Display a success message to the user
            MessageBox.Show("DataGridView data exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Call the method to export the DataGridView data to the text file
                ExportDataGridViewToTextFile(dataGridView1, filePath);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Check if any row is selected in the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Iterate over the selected rows in reverse order to avoid issues with index changes
                    for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[i];
                        int clientId = (int)selectedRow.Cells["ClientIdColumn"].Value;

                        // Retrieve the Client entity from the clientContext
                        Client client = clientContext.Clients.Find(clientId);

                        // Remove the Client entity from the clientContext
                        clientContext.Clients.Remove(client);
                    }

                    // Save the changes to the database
                    clientContext.SaveChanges();

                    // Remove the selected rows from the dataGridView1
                    foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }
            }
            else
            {
                // Show an error message if no row is selected
                MessageBox.Show("Please select a row to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
