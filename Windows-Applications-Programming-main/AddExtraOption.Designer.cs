namespace Project
{
    partial class AddExtraOption
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
            this.extraOptId = new System.Windows.Forms.NumericUpDown();
            this.extraOptName = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.extraOptId)).BeginInit();
            this.SuspendLayout();
            // 
            // extraOptId
            // 
            this.extraOptId.Location = new System.Drawing.Point(171, 56);
            this.extraOptId.Name = "extraOptId";
            this.extraOptId.Size = new System.Drawing.Size(120, 20);
            this.extraOptId.TabIndex = 0;
            this.extraOptId.ValueChanged += new System.EventHandler(this.extraOptId_ValueChanged);
            // 
            // extraOptName
            // 
            this.extraOptName.Location = new System.Drawing.Point(171, 113);
            this.extraOptName.Name = "extraOptName";
            this.extraOptName.Size = new System.Drawing.Size(120, 20);
            this.extraOptName.TabIndex = 1;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(37, 58);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(105, 18);
            this.labelid.TabIndex = 2;
            this.labelid.Text = "Extra option id:";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(37, 115);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(128, 18);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Extra option name:";
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(216, 206);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 4;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(40, 206);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // AddExtraOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 258);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.extraOptName);
            this.Controls.Add(this.extraOptId);
            this.Name = "AddExtraOption";
            this.Text = "Add extra option";
            ((System.ComponentModel.ISupportInitialize)(this.extraOptId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown extraOptId;
        private System.Windows.Forms.TextBox extraOptName;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button backbtn;
    }
}