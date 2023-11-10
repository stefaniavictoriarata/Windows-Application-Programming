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

namespace Project
{
    public partial class AddClient : Form
    {
        public List<Client> _clients;
        private ErrorProvider errorProvider;
        private readonly ClientContext clientContext;
        public AddClient(ClientContext clientContext)
        {
            this.clientContext = clientContext;
            InitializeComponent();
            
            _clients = new List<Client>();
            this.KeyPreview = true;

            // Attach the KeyDown event handler
            this.KeyDown += AddClient_KeyDown;
            // Initialize ErrorProvider
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;


        }

        private void AddClient_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Alt key is pressed and the S key is pressed simultaneously
            if (e.Alt && e.KeyCode == Keys.S)
            {
                // Perform the desired action
                // Here, we're triggering the Save button click event
                Savebtn_Click(sender, e);

                // Mark the key event as handled
                e.Handled = true;
            }
        }


        private void AddClient_Load(object sender, EventArgs e)
        {

        }

       

        private void Savebtn_Click(object sender, EventArgs e)
        {
            // Clear previous error messages
            errorProvider.Clear();
            string clientId = clientIdbt.Text;
            string extraOptionId = extraOptionIdbt.Text;
            string subscriptionId = subscriptionIdbt.Text;
            string clientName = clientNamebt.Text;
            string phoneNumber = phoneNumberbt.Text;

            // Validate Client ID (should be an integer)
            int parsedClientId;
            if (!int.TryParse(clientId, out parsedClientId))
            {
                errorProvider.SetError(clientIdbt, "Invalid client id.");
                return;
            }

            // Validate ExtraOption ID (should be an integer)
            int parsedExtraOptionId;
            if (!int.TryParse(extraOptionId, out parsedExtraOptionId))
            {
                errorProvider.SetError(extraOptionIdbt, "ExtraOption ID should be an integer.");
                return;
            }

            // Validate Subscription ID (should be an integer)
            int parsedSubscriptionId;
            if (!int.TryParse(subscriptionId, out parsedSubscriptionId))
            {
                errorProvider.SetError(subscriptionIdbt, "Subscription ID should be an integer.");
                return;
            }

            // Validate Phone Number (should be 10 digits)
            long parsedPhoneNumber;
            if (!long.TryParse(phoneNumber, out parsedPhoneNumber) || phoneNumber.Length != 10)
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var client = new Client(int.Parse(clientId), int.Parse(extraOptionId),
                int.Parse(subscriptionId), clientName, phoneNumber);
            _clients.Add(client);
            clientContext.Clients.Add(client);
            clientContext.SaveChanges();
            ClientForm mainForm = new ClientForm(clientContext);
            mainForm.Show();
            this.Hide();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
