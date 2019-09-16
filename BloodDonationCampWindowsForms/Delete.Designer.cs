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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebutton1 = new System.Windows.Forms.Button();
            this.IdtextBox1 = new System.Windows.Forms.TextBox();
            this.Cancelbutton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bloodDonationCampDataSet = new BloodDonationCampWindowsForms.BloodDonationCampDataSet();
            this.donorDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorDetailsTableAdapter = new BloodDonationCampWindowsForms.BloodDonationCampDataSetTableAdapters.DonorDetailsTableAdapter();
            this.donorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCollectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationCampDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Donor Id";
            // 
            // Deletebutton1
            // 
            this.Deletebutton1.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton1.Location = new System.Drawing.Point(388, 203);
            this.Deletebutton1.Name = "Deletebutton1";
            this.Deletebutton1.Size = new System.Drawing.Size(109, 38);
            this.Deletebutton1.TabIndex = 1;
            this.Deletebutton1.Text = "Delete";
            this.Deletebutton1.UseVisualStyleBackColor = false;
            this.Deletebutton1.Click += new System.EventHandler(this.Deletebutton1_Click);
            // 
            // IdtextBox1
            // 
            this.IdtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdtextBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdtextBox1.Location = new System.Drawing.Point(199, 111);
            this.IdtextBox1.Name = "IdtextBox1";
            this.IdtextBox1.Size = new System.Drawing.Size(298, 32);
            this.IdtextBox1.TabIndex = 2;
            // 
            // Cancelbutton2
            // 
            this.Cancelbutton2.BackColor = System.Drawing.Color.Transparent;
            this.Cancelbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbutton2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton2.Location = new System.Drawing.Point(46, 203);
            this.Cancelbutton2.Name = "Cancelbutton2";
            this.Cancelbutton2.Size = new System.Drawing.Size(109, 38);
            this.Cancelbutton2.TabIndex = 3;
            this.Cancelbutton2.Text = "Back";
            this.Cancelbutton2.UseVisualStyleBackColor = false;
            this.Cancelbutton2.Click += new System.EventHandler(this.Cancelbutton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delete Donor Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.unitCollectedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donorDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 239);
            this.dataGridView1.TabIndex = 5;
            // 
            // bloodDonationCampDataSet
            // 
            this.bloodDonationCampDataSet.DataSetName = "BloodDonationCampDataSet";
            this.bloodDonationCampDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorDetailsBindingSource
            // 
            this.donorDetailsBindingSource.DataMember = "DonorDetails";
            this.donorDetailsBindingSource.DataSource = this.bloodDonationCampDataSet;
            // 
            // donorDetailsTableAdapter
            // 
            this.donorDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // donorIDDataGridViewTextBoxColumn
            // 
            this.donorIDDataGridViewTextBoxColumn.DataPropertyName = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.HeaderText = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.Name = "donorIDDataGridViewTextBoxColumn";
            this.donorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            // 
            // unitCollectedDataGridViewTextBoxColumn
            // 
            this.unitCollectedDataGridViewTextBoxColumn.DataPropertyName = "UnitCollected";
            this.unitCollectedDataGridViewTextBoxColumn.HeaderText = "UnitCollected";
            this.unitCollectedDataGridViewTextBoxColumn.Name = "unitCollectedDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancelbutton2);
            this.Controls.Add(this.IdtextBox1);
            this.Controls.Add(this.Deletebutton1);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationCampDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deletebutton1;
        private System.Windows.Forms.TextBox IdtextBox1;
        private System.Windows.Forms.Button Cancelbutton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BloodDonationCampDataSet bloodDonationCampDataSet;
        private System.Windows.Forms.BindingSource donorDetailsBindingSource;
        private BloodDonationCampDataSetTableAdapters.DonorDetailsTableAdapter donorDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCollectedDataGridViewTextBoxColumn;
    }
}