namespace BloodDonationCampWindowsForms
{
    partial class View
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
            this.ViewrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ViewrichTextBox
            // 
            this.ViewrichTextBox.Location = new System.Drawing.Point(70, 70);
            this.ViewrichTextBox.Name = "ViewrichTextBox";
            this.ViewrichTextBox.Size = new System.Drawing.Size(631, 280);
            this.ViewrichTextBox.TabIndex = 0;
            this.ViewrichTextBox.Text = "";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewrichTextBox);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ViewrichTextBox;
    }
}