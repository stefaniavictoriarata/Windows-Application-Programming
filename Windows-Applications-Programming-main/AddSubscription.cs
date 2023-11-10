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

namespace Project
{
    public partial class AddSubscription : Form
    {
        public List<Subscription> _subscriptions;
        private readonly ClientContext clientContext;
        public AddSubscription(ClientContext clientContext)
        {
            InitializeComponent();
            _subscriptions = new List<Subscription>();
            this.clientContext = clientContext;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            var subscriptionId = subscrId.Value;
            var extraOptionId = extraoptId.Value;
            string name = namebtn.Text;
            string price = pricebtn.Text;

            var subscription = new Subscription(Convert.ToInt32(subscriptionId), 
                Convert.ToInt32(extraOptionId), name, 
                float.Parse(price));
            _subscriptions.Add(subscription);
            clientContext.Subscriptions.Add(subscription);
            clientContext.SaveChanges();
            SubscriptionForm mainForm = new SubscriptionForm(clientContext);
            mainForm.Show();
            this.Hide();
        }
    }
}
