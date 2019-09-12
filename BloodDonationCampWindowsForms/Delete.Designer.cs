namespace BloodDonationCampWindowsForms
{
    partial class Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebutton1 = new System.Windows.Forms.Button();
            this.IdtextBox1 = new System.Windows.Forms.TextBox();
            this.Cancelbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Id";
            // 
            // Deletebutton1
            // 
            this.Deletebutton1.Location = new System.Drawing.Point(476, 314);
            this.Deletebutton1.Name = "Deletebutton1";
            this.Deletebutton1.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton1.TabIndex = 1;
            this.Deletebutton1.Text = "Delete";
            this.Deletebutton1.UseVisualStyleBackColor = true;
            // 
            // IdtextBox1
            // 
            this.IdtextBox1.Location = new System.Drawing.Point(451, 86);
            this.IdtextBox1.Name = "IdtextBox1";
            this.IdtextBox1.Size = new System.Drawing.Size(100, 20);
            this.IdtextBox1.TabIndex = 2;
            // 
            // Cancelbutton2
            // 
            this.Cancelbutton2.Location = new System.Drawing.Point(246, 314);
            this.Cancelbutton2.Name = "Cancelbutton2";
            this.Cancelbutton2.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton2.TabIndex = 3;
            this.Cancelbutton2.Text = "Cancel";
            this.Cancelbutton2.UseVisualStyleBackColor = true;
            this.Cancelbutton2.Click += new System.EventHandler(this.Cancelbutton2_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelbutton2);
            this.Controls.Add(this.IdtextBox1);
            this.Controls.Add(this.Deletebutton1);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deletebutton1;
        private System.Windows.Forms.TextBox IdtextBox1;
        private System.Windows.Forms.Button Cancelbutton2;
    }
}