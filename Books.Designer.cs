namespace biblioteca
{
    partial class Books
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbState = new ComboBox();
            txtTitle = new TextBox();
            txtGender = new TextBox();
            txtAuthor = new TextBox();
            dgvListBooks = new DataGridView();
            bookControllerBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnOut = new Button();
            label6 = new Label();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 22);
            label1.Name = "label1";
            label1.Size = new Size(150, 26);
            label1.TabIndex = 0;
            label1.Text = "Registrar libros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 87);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 125);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 87);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 125);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 4;
            label5.Text = "Autor";
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(440, 123);
            cmbState.Margin = new Padding(3, 2, 3, 2);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(213, 23);
            cmbState.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(75, 82);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(258, 23);
            txtTitle.TabIndex = 6;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(440, 82);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(213, 23);
            txtGender.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(75, 120);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(258, 23);
            txtAuthor.TabIndex = 8;
            // 
            // dgvListBooks
            // 
            dgvListBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBooks.Location = new Point(76, 198);
            dgvListBooks.Margin = new Padding(3, 2, 3, 2);
            dgvListBooks.Name = "dgvListBooks";
            dgvListBooks.ReadOnly = true;
            dgvListBooks.RowHeadersWidth = 51;
            dgvListBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListBooks.Size = new Size(578, 252);
            dgvListBooks.TabIndex = 9;
            dgvListBooks.CellClick += dgvListBooks_CellClick;
            dgvListBooks.CellContentClick += dgvListBooks_CellContentClick;
            // 
            // bookControllerBindingSource
            // 
            bookControllerBindingSource.DataSource = typeof(Controllers.BookController);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 164);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 22);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 164);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 22);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 164);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 22);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(605, 22);
            btnOut.Margin = new Padding(3, 2, 3, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(104, 22);
            btnOut.TabIndex = 14;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 50);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 15;
            label6.Text = "Codigo";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(76, 52);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(0, 15);
            lblCodigo.TabIndex = 16;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(719, 461);
            Controls.Add(lblCodigo);
            Controls.Add(label6);
            Controls.Add(btnOut);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvListBooks);
            Controls.Add(txtAuthor);
            Controls.Add(txtGender);
            Controls.Add(txtTitle);
            Controls.Add(cmbState);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Books";
            Text = "Books";
            Load += Books_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbState;
        private TextBox txtTitle;
        private TextBox txtGender;
        private TextBox txtAuthor;
        private DataGridView dgvListBooks;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnOut;
        private BindingSource bookControllerBindingSource;
        private Label label6;
        private Label lblCodigo;
    }
}