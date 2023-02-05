
namespace Presentation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCustomerTypes = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgbCustomers = new System.Windows.Forms.DataGridView();
            this.btnInvocieView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manejo de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(207, 219);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(277, 22);
            this.tbName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(653, 213);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(277, 22);
            this.tbLastName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dirección";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(207, 261);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(724, 22);
            this.tbAddress.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estatus";
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Location = new System.Drawing.Point(119, 25);
            this.rbActivo.Margin = new System.Windows.Forms.Padding(5);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(67, 21);
            this.rbActivo.TabIndex = 14;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(221, 25);
            this.rbInactivo.Margin = new System.Windows.Forms.Padding(5);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(77, 21);
            this.rbInactivo.TabIndex = 15;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tipo Cliente";
            // 
            // cbCustomerTypes
            // 
            this.cbCustomerTypes.FormattingEnabled = true;
            this.cbCustomerTypes.Items.AddRange(new object[] {
            "Malo",
            "Bueno",
            "Regular"});
            this.cbCustomerTypes.Location = new System.Drawing.Point(603, 311);
            this.cbCustomerTypes.Margin = new System.Windows.Forms.Padding(5);
            this.cbCustomerTypes.Name = "cbCustomerTypes";
            this.cbCustomerTypes.Size = new System.Drawing.Size(212, 24);
            this.cbCustomerTypes.TabIndex = 17;
            this.cbCustomerTypes.SelectedIndexChanged += new System.EventHandler(this.cbCustomerTypes_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 587);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 34);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 585);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbActivo);
            this.groupBox1.Controls.Add(this.rbInactivo);
            this.groupBox1.Location = new System.Drawing.Point(84, 295);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(329, 64);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbStatus";
            // 
            // dgbCustomers
            // 
            this.dgbCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbCustomers.Location = new System.Drawing.Point(89, 398);
            this.dgbCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgbCustomers.Name = "dgbCustomers";
            this.dgbCustomers.RowHeadersWidth = 51;
            this.dgbCustomers.Size = new System.Drawing.Size(726, 148);
            this.dgbCustomers.TabIndex = 21;
            this.dgbCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbCustomers_CellContentClick);
            this.dgbCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbCustomers_CellContentClick_1);
            // 
            // btnInvocieView
            // 
            this.btnInvocieView.Location = new System.Drawing.Point(848, 398);
            this.btnInvocieView.Name = "btnInvocieView";
            this.btnInvocieView.Size = new System.Drawing.Size(169, 23);
            this.btnInvocieView.TabIndex = 22;
            this.btnInvocieView.Text = "VerFactura";
            this.btnInvocieView.UseVisualStyleBackColor = true;
            this.btnInvocieView.Click += new System.EventHandler(this.btnInvocieView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 635);
            this.Controls.Add(this.btnInvocieView);
            this.Controls.Add(this.dgbCustomers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCustomerTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCustomerTypes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgbCustomers;
        private System.Windows.Forms.Button btnInvocieView;
    }
}

