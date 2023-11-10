namespace Project
{
    partial class AddSubscription
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
            this.subscrId = new System.Windows.Forms.NumericUpDown();
            this.extraoptId = new System.Windows.Forms.NumericUpDown();
            this.namebtn = new System.Windows.Forms.TextBox();
            this.pricebtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subscrId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraoptId)).BeginInit();
            this.SuspendLayout();
            // 
            // subscrId
            // 
            this.subscrId.Location = new System.Drawing.Point(152, 62);
            this.subscrId.Name = "subscrId";
            this.subscrId.Size = new System.Drawing.Size(120, 20);
            this.subscrId.TabIndex = 0;
            // 
            // extraoptId
            // 
            this.extraoptId.Location = new System.Drawing.Point(152, 102);
            this.extraoptId.Name = "extraoptId";
            this.extraoptId.Size = new System.Drawing.Size(120, 20);
            this.extraoptId.TabIndex = 1;
            // 
            // namebtn
            // 
            this.namebtn.Location = new System.Drawing.Point(152, 148);
            this.namebtn.Name = "namebtn";
            this.namebtn.Size = new System.Drawing.Size(120, 20);
            this.namebtn.TabIndex = 2;
            // 
            // pricebtn
            // 
            this.pricebtn.Location = new System.Drawing.Point(152, 199);
            this.pricebtn.Name = "pricebtn";
            this.pricebtn.Size = new System.Drawing.Size(120, 20);
            this.pricebtn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subscription id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Extra option id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(42, 257);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(216, 257);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // AddSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 313);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pricebtn);
            this.Controls.Add(this.namebtn);
            this.Controls.Add(this.extraoptId);
            this.Controls.Add(this.subscrId);
            this.Name = "AddSubscription";
            this.Text = "Add Subscription";
            ((System.ComponentModel.ISupportInitialize)(this.subscrId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraoptId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown subscrId;
        private System.Windows.Forms.NumericUpDown extraoptId;
        private System.Windows.Forms.TextBox namebtn;
        private System.Windows.Forms.TextBox pricebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button savebtn;
    }
}