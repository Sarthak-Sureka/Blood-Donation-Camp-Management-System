namespace BloodDonationCampWindowsForms
{
    partial class Idtobeupdates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Idtobeupdates));
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelbutton2 = new System.Windows.Forms.Button();
            this.IdtextBox1 = new System.Windows.Forms.TextBox();
            this.Deletebutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Update Donor Details";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cancelbutton2
            // 
            this.Cancelbutton2.BackColor = System.Drawing.Color.Transparent;
            this.Cancelbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbutton2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton2.Location = new System.Drawing.Point(65, 286);
            this.Cancelbutton2.Name = "Cancelbutton2";
            this.Cancelbutton2.Size = new System.Drawing.Size(109, 38);
            this.Cancelbutton2.TabIndex = 8;
            this.Cancelbutton2.Text = "Back";
            this.Cancelbutton2.UseVisualStyleBackColor = false;
            this.Cancelbutton2.Click += new System.EventHandler(this.Cancelbutton2_Click);
            // 
            // IdtextBox1
            // 
            this.IdtextBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdtextBox1.Location = new System.Drawing.Point(192, 165);
            this.IdtextBox1.Name = "IdtextBox1";
            this.IdtextBox1.Size = new System.Drawing.Size(308, 32);
            this.IdtextBox1.TabIndex = 7;
            // 
            // Deletebutton1
            // 
            this.Deletebutton1.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton1.Location = new System.Drawing.Point(353, 286);
            this.Deletebutton1.Name = "Deletebutton1";
            this.Deletebutton1.Size = new System.Drawing.Size(109, 38);
            this.Deletebutton1.TabIndex = 6;
            this.Deletebutton1.Text = "Edit";
            this.Deletebutton1.UseVisualStyleBackColor = false;
            this.Deletebutton1.Click += new System.EventHandler(this.Deletebutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Donor Id";
            // 
            // Idtobeupdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancelbutton2);
            this.Controls.Add(this.IdtextBox1);
            this.Controls.Add(this.Deletebutton1);
            this.Controls.Add(this.label1);
            this.Name = "Idtobeupdates";
            this.Text = "Idtobeupdates";
            this.Load += new System.EventHandler(this.Idtobeupdates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancelbutton2;
        private System.Windows.Forms.TextBox IdtextBox1;
        private System.Windows.Forms.Button Deletebutton1;
        private System.Windows.Forms.Label label1;
    }
}