
namespace Presentation
{
    partial class InvoiceDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetailView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgbInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTotalItbis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbInvoiceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detalle de Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Factura No. ";
            // 
            // dgbInvoiceDetail
            // 
            this.dgbInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbInvoiceDetail.Location = new System.Drawing.Point(56, 284);
            this.dgbInvoiceDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgbInvoiceDetail.Name = "dgbInvoiceDetail";
            this.dgbInvoiceDetail.RowHeadersWidth = 51;
            this.dgbInvoiceDetail.Size = new System.Drawing.Size(827, 102);
            this.dgbInvoiceDetail.TabIndex = 24;
            this.dgbInvoiceDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbInvoiceDetail_CellContentClick);
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(139, 211);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(121, 22);
            this.tbCustomerId.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Qty";
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(87, 246);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(58, 22);
            this.tbQty.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Price";
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(210, 246);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(58, 22);
            this.TbPrice.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "TotalItbis";
            // 
            // tbTotalItbis
            // 
            this.tbTotalItbis.Location = new System.Drawing.Point(362, 249);
            this.tbTotalItbis.Name = "tbTotalItbis";
            this.tbTotalItbis.Size = new System.Drawing.Size(58, 22);
            this.tbTotalItbis.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Subtotal";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Location = new System.Drawing.Point(509, 249);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(58, 22);
            this.tbSubtotal.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(650, 249);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(58, 22);
            this.tbTotal.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 26);
            this.button1.TabIndex = 36;
            this.button1.Text = "Agregar Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 26);
            this.button2.TabIndex = 37;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InvoiceDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTotalItbis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCustomerId);
            this.Controls.Add(this.dgbInvoiceDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InvoiceDetailView";
            this.Text = "InvoiceDetailView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbInvoiceDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgbInvoiceDetail;
        private System.Windows.Forms.TextBox tbCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotalItbis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}