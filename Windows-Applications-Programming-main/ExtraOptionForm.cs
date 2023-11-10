using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace Project
{
    public partial class ExtraOptionForm : Form
    {
        private readonly ClientContext clientContext;
        public ExtraOptionForm _extraOptionForm;

        public ExtraOptionForm(ClientContext clientContext)
        {
            InitializeComponent();
            ExtraOptionForm_Load(null, EventArgs.Empty);
            this.clientContext = clientContext;
            AddExtraOptionToDataView();
        }

        private void ExtraOptionForm_Load(object sender, EventArgs e)
        {


            // Add columns to the DataGridView
            dataGridView1.Columns.Add("ExtraOptionNameColumn", "Extra Option Name");
            dataGridView1.Columns.Add("ExtraOptionIdColumn", "Extra Option ID");

            // Optional: Set column properties such as width, alignment, etc.
            dataGridView1.Columns["ExtraOptionNameColumn"].Width = 200;
            dataGridView1.Columns["ExtraOptionIdColumn"].Width = 100;

        }

        public void AddExtraOptionToDataView()
        {
            dataGridView1.Rows.Clear(); // Clear existing rows in the DataGridView
            List<ExtraOption> extraOptions = clientContext.ExtraOptions.ToList();

            foreach (ExtraOption extraOption in extraOptions)
            {
                dataGridView1.Rows.Add(extraOption.Name, extraOption.ExtraOptionId);
            }

        }

        private void Addextrabtn_Click(object sender, EventArgs e)
        {
            ClientContext context = new ClientContext();
            Form form = new AddExtraOption(context);
            form.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Iterate over the selected rows in reverse order to avoid issues with index changes
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[i];
                    int extraOptionId = (int)selectedRow.Cells["ExtraOptionIdColumn"].Value;

                    // Retrieve the ExtraOption entity from the clientContext
                    ExtraOption extraOption = clientContext.ExtraOptions.Find(extraOptionId);

                    // Remove the ExtraOption entity from the clientContext
                    clientContext.ExtraOptions.Remove(extraOption);
                }

                // Save the changes to the database
                clientContext.SaveChanges();

                // Remove the selected rows from the dataGridView1
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(selectedRow);
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

        // Copy selected cells to clipboard
        private void CopySelectedCells()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the selected cell values as a tab-delimited string
                var selectedCells = dataGridView1.GetClipboardContent();
                Clipboard.SetDataObject(selectedCells);
            }
        }

        // Paste cell values from clipboard to the DataGridView
        private void PasteCellValues()
        {
            var clipboardData = Clipboard.GetDataObject();

            if (clipboardData != null && clipboardData.GetDataPresent(DataFormats.Text))
            {
                var clipboardText = clipboardData.GetData(DataFormats.Text).ToString();
                var rows = clipboardText.Split('\n');

                foreach (var row in rows)
                {
                    if (!string.IsNullOrWhiteSpace(row))
                    {
                        var values = row.Trim().Split('\t');
                        dataGridView1.Rows.Add(values);
                    }
                }
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            CopySelectedCells();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            PasteCellValues();
        }
    }
}
