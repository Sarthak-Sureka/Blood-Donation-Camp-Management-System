namespace BloodDonationCampWindowsForms
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.Nextbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nextbutton
            // 
            this.Nextbutton.BackColor = System.Drawing.Color.White;
            this.Nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nextbutton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbutton.ForeColor = System.Drawing.Color.Red;
            this.Nextbutton.Location = new System.Drawing.Point(187, 456);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(238, 48);
            this.Nextbutton.TabIndex = 0;
            this.Nextbutton.Text = "Go To Menu";
            this.Nextbutton.UseVisualStyleBackColor = false;
            this.Nextbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 516);
            this.Controls.Add(this.Nextbutton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Homepage";
            this.Text = "Blood Donation Camp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nextbutton;
    }
}

