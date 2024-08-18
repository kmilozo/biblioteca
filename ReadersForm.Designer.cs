namespace biblioteca
{
    partial class ReadersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadersForm));
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvListReaders = new DataGridView();
            txtIdNumber = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOut = new Button();
            label3 = new Label();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListReaders).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 156);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 22);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 156);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 22);
            btnAdd.TabIndex = 47;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvListReaders
            // 
            dgvListReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListReaders.Location = new Point(171, 197);
            dgvListReaders.Margin = new Padding(3, 2, 3, 2);
            dgvListReaders.Name = "dgvListReaders";
            dgvListReaders.ReadOnly = true;
            dgvListReaders.RowHeadersWidth = 51;
            dgvListReaders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListReaders.Size = new Size(433, 252);
            dgvListReaders.TabIndex = 46;
            dgvListReaders.CellClick += dgvListReaders_CellClick;
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(172, 112);
            txtIdNumber.Margin = new Padding(3, 2, 3, 2);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(258, 23);
            txtIdNumber.TabIndex = 45;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(539, 74);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(213, 23);
            txtPhone.TabIndex = 44;
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 74);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 23);
            txtName.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 118);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 42;
            label5.Text = "Numero identificacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 80);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 41;
            label4.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 40;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 14);
            label1.Name = "label1";
            label1.Size = new Size(187, 26);
            label1.TabIndex = 39;
            label1.Text = "Registro de lectores";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(653, 17);
            btnOut.Margin = new Padding(3, 2, 3, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(102, 22);
            btnOut.TabIndex = 50;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 44);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 51;
            label3.Text = "Codigo";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(171, 47);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(10, 15);
            lblCodigo.TabIndex = 52;
            lblCodigo.Text = " ";
            // 
            // ReadersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(763, 494);
            Controls.Add(lblCodigo);
            Controls.Add(label3);
            Controls.Add(btnOut);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvListReaders);
            Controls.Add(txtIdNumber);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReadersForm";
            Text = "ReadersForm";
            Load += ReadersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListReaders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvListReaders;
        private TextBox txtIdNumber;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnOut;
        private Label label3;
        private Label lblCodigo;
    }
}