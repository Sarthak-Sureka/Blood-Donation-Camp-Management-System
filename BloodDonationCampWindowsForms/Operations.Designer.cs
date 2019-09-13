namespace BloodDonationCampWindowsForms
{
    partial class Operations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operations));
            this.Savebutton = new System.Windows.Forms.Button();
            this.Viewbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.Transparent;
            this.Savebutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebutton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.ForeColor = System.Drawing.Color.Black;
            this.Savebutton.Location = new System.Drawing.Point(208, 136);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(138, 43);
            this.Savebutton.TabIndex = 0;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Viewbutton
            // 
            this.Viewbutton.BackColor = System.Drawing.Color.Transparent;
            this.Viewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewbutton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbutton.ForeColor = System.Drawing.Color.Black;
            this.Viewbutton.Location = new System.Drawing.Point(29, 245);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(138, 43);
            this.Viewbutton.TabIndex = 1;
            this.Viewbutton.Text = "View";
            this.Viewbutton.UseVisualStyleBackColor = false;
            this.Viewbutton.Click += new System.EventHandler(this.Viewbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.Transparent;
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.Black;
            this.Updatebutton.Location = new System.Drawing.Point(389, 245);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(138, 43);
            this.Updatebutton.TabIndex = 2;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.Black;
            this.Deletebutton.Location = new System.Drawing.Point(208, 340);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(138, 43);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(215, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(43, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(555, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Viewbutton);
            this.Controls.Add(this.Savebutton);
            this.Name = "Operations";
            this.Text = "Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Viewbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}