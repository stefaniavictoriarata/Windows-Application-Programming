namespace Project
{
    partial class SubscriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriptionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AddSubscbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.serbtn = new System.Windows.Forms.Button();
            this.deserbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printbtn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subscriptions";
            // 
            // AddSubscbtn
            // 
            this.AddSubscbtn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubscbtn.Location = new System.Drawing.Point(36, 244);
            this.AddSubscbtn.Name = "AddSubscbtn";
            this.AddSubscbtn.Size = new System.Drawing.Size(183, 39);
            this.AddSubscbtn.TabIndex = 2;
            this.AddSubscbtn.Text = "Add new subscription";
            this.AddSubscbtn.UseVisualStyleBackColor = true;
            this.AddSubscbtn.Click += new System.EventHandler(this.AddSubscbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(36, 289);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(96, 29);
            this.homebtn.TabIndex = 3;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(585, 244);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(96, 29);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // serbtn
            // 
            this.serbtn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serbtn.Location = new System.Drawing.Point(463, 47);
            this.serbtn.Name = "serbtn";
            this.serbtn.Size = new System.Drawing.Size(106, 29);
            this.serbtn.TabIndex = 5;
            this.serbtn.Text = "Export XML";
            this.serbtn.UseVisualStyleBackColor = true;
            this.serbtn.Click += new System.EventHandler(this.serbtn_Click);
            // 
            // deserbtn
            // 
            this.deserbtn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deserbtn.Location = new System.Drawing.Point(575, 47);
            this.deserbtn.Name = "deserbtn";
            this.deserbtn.Size = new System.Drawing.Size(106, 29);
            this.deserbtn.TabIndex = 6;
            this.deserbtn.TabStop = false;
            this.deserbtn.Text = "Deserialize";
            this.deserbtn.UseVisualStyleBackColor = true;
            this.deserbtn.Click += new System.EventHandler(this.deserbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 146);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // printbtn
            // 
            this.printbtn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Location = new System.Drawing.Point(585, 289);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(96, 29);
            this.printbtn.TabIndex = 8;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 337);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deserbtn);
            this.Controls.Add(this.serbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.AddSubscbtn);
            this.Controls.Add(this.label1);
            this.Name = "SubscriptionForm";
            this.Text = "SubscriptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSubscbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button serbtn;
        private System.Windows.Forms.Button deserbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}