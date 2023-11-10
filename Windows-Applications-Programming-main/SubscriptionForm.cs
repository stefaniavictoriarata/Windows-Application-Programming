using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class SubscriptionForm : Form
    {
        private readonly ClientContext clientContext;
        public SubscriptionForm(ClientContext clientContext)
        {
            InitializeComponent();
            SubscriptionForm_Load(null, EventArgs.Empty);
            this.clientContext = clientContext;
            AddSubscriptionToDataView();
        }

        private void SubscriptionForm_Load(object sender, EventArgs e)
        {
              // Add columns to the DataGridView
            dataGridView1.Columns.Add("SubscriptionIdColumn", "Subscription ID");
            dataGridView1.Columns.Add("ExtraOptionIdColumn", "Extra Option ID");
            dataGridView1.Columns.Add("NameColumn", "Name");
            dataGridView1.Columns.Add("PriceColumn", "Price");

            // Optional: Set column properties such as width, alignment, etc.
            dataGridView1.Columns["SubscriptionIdColumn"].Width = 100;
            dataGridView1.Columns["ExtraOptionIdColumn"].Width = 100;
            dataGridView1.Columns["NameColumn"].Width = 100;
            dataGridView1.Columns["PriceColumn"].Width = 100;
        }

        private void AddSubscbtn_Click(object sender, EventArgs e)
        {
            ClientContext context = new ClientContext();
            Form form = new AddSubscription(context);
            form.Show();
            this.Hide();
        }

      

        public void AddSubscriptionToDataView()
        {
            List<Subscription> subscriptions = clientContext.Subscriptions.ToList();
            dataGridView1.Rows.Clear(); // Clear existing rows in the DataGridView

            foreach (Subscription subscription in subscriptions)
            {
                dataGridView1.Rows.Add(subscription.SubscriptionId, subscription.ExtraOptionId, 
                    subscription.Name, subscription.Price);
            }

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
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
                        int subscriptionId = (int)selectedRow.Cells["SubscriptionIdColumn"].Value;


                        // Retrieve the Subscription entity associated with the Client
                        Subscription subscription = clientContext.Subscriptions.Find(subscriptionId);


                        // Remove the Subscription entity from the clientContext
                        clientContext.Subscriptions.Remove(subscription);


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
        private List<Subscription> GetSubscriptions()
        {
            List<Subscription> subscriptions = new List<Subscription>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Skip the new row if present
                {
                    int subscriptionId = Convert.ToInt32(row.Cells["SubscriptionIdColumn"].Value);
                    int extraOptionId = Convert.ToInt32(row.Cells["ExtraOptionIdColumn"].Value);
                    string subscriptionName = Convert.ToString(row.Cells["NameColumn"].Value);
                    float price = Convert.ToSingle(row.Cells["PriceColumn"].Value);

                    Subscription subscription = new Subscription(subscriptionId, extraOptionId, subscriptionName, price);
                    subscriptions.Add(subscription);
                }
            }

            return subscriptions;

        }
        // Serialization
        private void SerializeData(List<Subscription> subscriptions)
        {
            // Create an instance of the XmlSerializer for the Subscription type
            XmlSerializer serializer = new XmlSerializer(typeof(List<Subscription>));

            // Create a FileStream to write the serialized data to a file
            using (FileStream fileStream = new FileStream("subscriptions.xml", FileMode.Create))
            {
                // Use the serializer to serialize the subscriptions list to the file stream
                serializer.Serialize(fileStream, subscriptions);
            }
        }

        // Deserialization
        private List<Subscription> DeserializeData()
        {
            // Create an instance of the XmlSerializer for the Subscription type
            XmlSerializer serializer = new XmlSerializer(typeof(List<Subscription>));

            // Create a FileStream to read the serialized data from a file
            using (FileStream fileStream = new FileStream("subscriptions.xml", FileMode.Open))
            {
                // Use the serializer to deserialize the file stream and cast it to the list of subscriptions
                return (List<Subscription>)serializer.Deserialize(fileStream);
            }
        }

        private void SaveData()
        {
            // Get the list of subscriptions from your form's data source
            List<Subscription> subscriptions = GetSubscriptions();

            // Call the serialization method to save the data
            SerializeData(subscriptions);

            // Show a message or perform any other necessary actions
            MessageBox.Show("Data saved successfully.");
        }

        private void serbtn_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void deserbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Call the deserialization method to retrieve the list of subscriptions
                List<Subscription> subscriptions = DeserializeData();

                // Update the ListView with the deserialized data
                AddSubscriptionToDataView();

                // Show a message or perform any other necessary actions
                MessageBox.Show("Data deserialized successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during deserialization
                MessageBox.Show("Error occurred during deserialization: " + ex.Message, "Deserialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintDocument_PrintPage;

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dataGridView = dataGridView1;
            Font font = new Font("Arial", 10);
            int margin = 100;
            int lineHeight = font.Height + 50;

            float startX = margin;
            float startY = margin;

            // Print column headers
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, font, Brushes.Black, startX, startY);
                startX += column.Width;
            }

            startY += lineHeight;

            // Print data rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                startX = margin;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value?.ToString(), font, Brushes.Black, startX, startY);
                    startX += dataGridView.Columns[cell.ColumnIndex].Width;
                }
                startY += lineHeight;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
  
}
