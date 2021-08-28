﻿
namespace Advanced_Gym_Management_System
{
    partial class CustomerIndividualPayHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerIndividualPayHistory));
            this.Searchbut = new System.Windows.Forms.Button();
            this.txtEnterId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PayDGV = new System.Windows.Forms.DataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slim_Lady_FitnessDataSet3 = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet3();
            this.paymentTableAdapter = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet3TableAdapters.PaymentTableAdapter();
            this.butHis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchbut
            // 
            this.Searchbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Searchbut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Searchbut.FlatAppearance.BorderSize = 0;
            this.Searchbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Searchbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbut.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Searchbut.Location = new System.Drawing.Point(40, 359);
            this.Searchbut.Name = "Searchbut";
            this.Searchbut.Size = new System.Drawing.Size(211, 70);
            this.Searchbut.TabIndex = 117;
            this.Searchbut.Text = "SEARCH";
            this.Searchbut.UseVisualStyleBackColor = false;
            this.Searchbut.Click += new System.EventHandler(this.Searchbut_Click);
            // 
            // txtEnterId
            // 
            this.txtEnterId.BackColor = System.Drawing.Color.Black;
            this.txtEnterId.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtEnterId.Location = new System.Drawing.Point(40, 282);
            this.txtEnterId.Name = "txtEnterId";
            this.txtEnterId.Size = new System.Drawing.Size(211, 40);
            this.txtEnterId.TabIndex = 116;
            this.txtEnterId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(34, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(217, 33);
            this.label17.TabIndex = 115;
            this.label17.Text = "Enter Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(459, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(717, 39);
            this.label2.TabIndex = 114;
            this.label2.Text = "INDIVIDUAL CUSTOMER PAYMENT DETAILS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(594, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 48);
            this.label1.TabIndex = 112;
            this.label1.Text = "ADVANCED GYM MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // PayDGV
            // 
            this.PayDGV.AutoGenerateColumns = false;
            this.PayDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.pDateDataGridViewTextBoxColumn,
            this.pAmountDataGridViewTextBoxColumn});
            this.PayDGV.DataSource = this.paymentBindingSource;
            this.PayDGV.Location = new System.Drawing.Point(466, 188);
            this.PayDGV.Name = "PayDGV";
            this.PayDGV.RowHeadersWidth = 62;
            this.PayDGV.RowTemplate.Height = 28;
            this.PayDGV.Size = new System.Drawing.Size(1057, 491);
            this.PayDGV.TabIndex = 118;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "Payment ID";
            this.pIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pDateDataGridViewTextBoxColumn
            // 
            this.pDateDataGridViewTextBoxColumn.DataPropertyName = "pDate";
            this.pDateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.pDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pDateDataGridViewTextBoxColumn.Name = "pDateDataGridViewTextBoxColumn";
            this.pDateDataGridViewTextBoxColumn.Width = 300;
            // 
            // pAmountDataGridViewTextBoxColumn
            // 
            this.pAmountDataGridViewTextBoxColumn.DataPropertyName = "pAmount";
            this.pAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.pAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pAmountDataGridViewTextBoxColumn.Name = "pAmountDataGridViewTextBoxColumn";
            this.pAmountDataGridViewTextBoxColumn.Width = 250;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.slim_Lady_FitnessDataSet3;
            // 
            // slim_Lady_FitnessDataSet3
            // 
            this.slim_Lady_FitnessDataSet3.DataSetName = "Slim_Lady_FitnessDataSet3";
            this.slim_Lady_FitnessDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // butHis
            // 
            this.butHis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butHis.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butHis.FlatAppearance.BorderSize = 0;
            this.butHis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.butHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHis.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butHis.Location = new System.Drawing.Point(40, 474);
            this.butHis.Name = "butHis";
            this.butHis.Size = new System.Drawing.Size(211, 65);
            this.butHis.TabIndex = 126;
            this.butHis.Text = "BACK";
            this.butHis.UseVisualStyleBackColor = false;
            this.butHis.Click += new System.EventHandler(this.butHis_Click);
            // 
            // CustomerIndividualPayHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1688, 849);
            this.Controls.Add(this.butHis);
            this.Controls.Add(this.PayDGV);
            this.Controls.Add(this.Searchbut);
            this.Controls.Add(this.txtEnterId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1710, 905);
            this.MinimumSize = new System.Drawing.Size(1710, 905);
            this.Name = "CustomerIndividualPayHistory";
            this.Text = "CustomerIndividualPayHistory";
            this.Load += new System.EventHandler(this.CustomerIndividualPayHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbut;
        private System.Windows.Forms.TextBox txtEnterId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PayDGV;
        private Slim_Lady_FitnessDataSet3 slim_Lady_FitnessDataSet3;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Slim_Lady_FitnessDataSet3TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button butHis;
    }
}