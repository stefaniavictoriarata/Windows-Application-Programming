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
    public partial class MainForm : Form
    {
        ClientContext context = new ClientContext();
        public MainForm()
        {
            InitializeComponent();
        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AddClient(context);
            form.Show();
            this.Hide();
        }


        private void extraOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AddExtraOption(context);
            form.Show();
            this.Hide();
        }

        private void subscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AddSubscription(context);
            form.Show();
            this.Hide();
        }

        private void DrawChart(Graphics graphics)
        {
            // Define the data for the chart
            int[] data = { 20, 40, 60, 80, 100 };

            // Define the chart dimensions
            int chartWidth = 400;
            int chartHeight = 300;
            int barWidth = chartWidth / data.Length;

            // Define the maximum value in the data
            int maxValue = data.Max();

            // Set up the font for drawing labels
            Font labelFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);

            // Set up the brush and pen for drawing bars
            Brush barBrush = Brushes.Blue;
            Pen barPen = Pens.Black;

            // Draw the chart background
            graphics.Clear(Color.White);

            // Draw the bars
            for (int i = 0; i < data.Length; i++)
            {
                int barHeight = (int)((data[i] / (float)maxValue) * chartHeight);
                int x = i * barWidth;
                int y = chartHeight - barHeight;
                Rectangle barRect = new Rectangle(x, y, barWidth, barHeight);
                graphics.FillRectangle(barBrush, barRect);
                graphics.DrawRectangle(barPen, barRect);
            }

            // Draw the labels
            for (int i = 0; i < data.Length; i++)
            {
                int x = i * barWidth + barWidth / 2;
                int y = chartHeight + 5;
                string label = (i + 1).ToString();
                SizeF labelSize = graphics.MeasureString(label, labelFont);
                graphics.DrawString(label, labelFont, Brushes.Black, x - labelSize.Width / 2, y);
            }
        }

        private void pictureBox1_Clicked(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            DrawChart(graphics);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1, 0, button1.Height);
        }

        private void clientsRegisteredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ClientForm(context);
            form.Show();
            this.Hide();
        }

        private void extraOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ExtraOptionForm(context);
            form.Show();
            this.Hide();
        }

        private void subscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SubscriptionForm(context);
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
