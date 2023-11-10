using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddExtraOption : Form
    {
        ExtraOptionForm extraOptionForm;
        List<ExtraOption> _extraOptions;
        private readonly ClientContext clientContext;

        public AddExtraOption(ClientContext clientContext)
        {
            InitializeComponent();
            _extraOptions = new List<ExtraOption>();
            this.clientContext = clientContext;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

           var extraOptionId = extraOptId.Value;
            string name = extraOptName.Text;

            var extraoption = new ExtraOption(Convert.ToInt32(extraOptionId), name);
            _extraOptions.Add(extraoption);
            clientContext.ExtraOptions.Add(extraoption);
            clientContext.SaveChanges();
            ExtraOptionForm mainForm = new ExtraOptionForm(clientContext);
            mainForm.AddExtraOptionToDataView();
            mainForm.Show();
            this.Hide();
        }

        private void extraOptId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
