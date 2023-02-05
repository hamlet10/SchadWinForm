
namespace Presentation
{
    partial class InvoiceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbCustomerType = new System.Windows.Forms.Label();
            this.dgbInvoices = new System.Windows.Forms.DataGridView();
            this.btDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Facturas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(72, 181);
            this.lbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 25);
            this.lbName.TabIndex = 5;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(72, 223);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(0, 25);
            this.lbAddress.TabIndex = 12;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(75, 260);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 25);
            this.lbStatus.TabIndex = 13;
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.AutoSize = true;
            this.lbCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerType.Location = new System.Drawing.Point(75, 297);
            this.lbCustomerType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(0, 25);
            this.lbCustomerType.TabIndex = 17;
            // 
            // dgbInvoices
            // 
            this.dgbInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbInvoices.Location = new System.Drawing.Point(60, 360);
            this.dgbInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.dgbInvoices.Name = "dgbInvoices";
            this.dgbInvoices.RowHeadersWidth = 51;
            this.dgbInvoices.Size = new System.Drawing.Size(595, 102);
            this.dgbInvoices.TabIndex = 23;
            this.dgbInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbInvoices_CellContentClick);
            // 
            // btDetail
            // 
            this.btDetail.Location = new System.Drawing.Point(675, 360);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(92, 23);
            this.btDetail.TabIndex = 24;
            this.btDetail.Text = "VerDetalle";
            this.btDetail.UseVisualStyleBackColor = true;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // InvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.btDetail);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.dgbInvoices);
            this.Controls.Add(this.lbCustomerType);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InvoiceView";
            this.Text = "InvoiceView";
            this.Load += new System.EventHandler(this.InvoiceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbCustomerType;
        private System.Windows.Forms.DataGridView dgbInvoices;
        private System.Windows.Forms.Button btDetail;
    }
}