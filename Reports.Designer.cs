namespace biblioteca
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            label1 = new Label();
            dgvReports = new DataGridView();
            btnActualState = new Button();
            btnExpirateBooks = new Button();
            btnMoreBorrowings = new Button();
            btnForTitle = new Button();
            label2 = new Label();
            btnOut = new Button();
            btnForAuthor = new Button();
            btnForGender = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(92, 26);
            label1.TabIndex = 12;
            label1.Text = "Reportes";
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(21, 116);
            dgvReports.Margin = new Padding(3, 2, 3, 2);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(849, 136);
            dgvReports.TabIndex = 13;
            // 
            // btnActualState
            // 
            btnActualState.Location = new Point(12, 74);
            btnActualState.Margin = new Padding(3, 2, 3, 2);
            btnActualState.Name = "btnActualState";
            btnActualState.Size = new Size(217, 22);
            btnActualState.TabIndex = 14;
            btnActualState.Text = "Estado actual de la biblioteca";
            btnActualState.UseVisualStyleBackColor = true;
            btnActualState.Click += btnActualState_Click;
            // 
            // btnExpirateBooks
            // 
            btnExpirateBooks.Location = new Point(531, 74);
            btnExpirateBooks.Margin = new Padding(3, 2, 3, 2);
            btnExpirateBooks.Name = "btnExpirateBooks";
            btnExpirateBooks.Size = new Size(217, 22);
            btnExpirateBooks.TabIndex = 15;
            btnExpirateBooks.Text = "Libros vencidos";
            btnExpirateBooks.UseVisualStyleBackColor = true;
            btnExpirateBooks.Click += btnExpirateBooks_Click;
            // 
            // btnMoreBorrowings
            // 
            btnMoreBorrowings.Location = new Point(264, 74);
            btnMoreBorrowings.Margin = new Padding(3, 2, 3, 2);
            btnMoreBorrowings.Name = "btnMoreBorrowings";
            btnMoreBorrowings.Size = new Size(217, 22);
            btnMoreBorrowings.TabIndex = 16;
            btnMoreBorrowings.Text = "Libros mas prestados";
            btnMoreBorrowings.UseVisualStyleBackColor = true;
            btnMoreBorrowings.Click += button2_Click;
            // 
            // btnForTitle
            // 
            btnForTitle.Location = new Point(256, 378);
            btnForTitle.Margin = new Padding(3, 2, 3, 2);
            btnForTitle.Name = "btnForTitle";
            btnForTitle.Size = new Size(71, 22);
            btnForTitle.TabIndex = 20;
            btnForTitle.Text = "Por Titulo";
            btnForTitle.UseVisualStyleBackColor = true;
            btnForTitle.Click += btnGender_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 314);
            label2.Name = "label2";
            label2.Size = new Size(183, 26);
            label2.TabIndex = 17;
            label2.Text = "Consultas de libros";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(773, 21);
            btnOut.Margin = new Padding(3, 2, 3, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(80, 22);
            btnOut.TabIndex = 28;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // btnForAuthor
            // 
            btnForAuthor.Location = new Point(375, 378);
            btnForAuthor.Margin = new Padding(3, 2, 3, 2);
            btnForAuthor.Name = "btnForAuthor";
            btnForAuthor.Size = new Size(71, 22);
            btnForAuthor.TabIndex = 29;
            btnForAuthor.Text = "Por Autor";
            btnForAuthor.UseVisualStyleBackColor = true;
            btnForAuthor.Click += btnAuthor_Click_1;
            // 
            // btnForGender
            // 
            btnForGender.Location = new Point(474, 378);
            btnForGender.Margin = new Padding(3, 2, 3, 2);
            btnForGender.Name = "btnForGender";
            btnForGender.Size = new Size(93, 22);
            btnForGender.TabIndex = 30;
            btnForGender.Text = "Por Genero";
            btnForGender.UseVisualStyleBackColor = true;
            btnForGender.Click += btnGender_Click_1;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(885, 546);
            Controls.Add(btnForGender);
            Controls.Add(btnForAuthor);
            Controls.Add(btnOut);
            Controls.Add(btnForTitle);
            Controls.Add(label2);
            Controls.Add(btnMoreBorrowings);
            Controls.Add(btnExpirateBooks);
            Controls.Add(btnActualState);
            Controls.Add(dgvReports);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvReports;
        private Button btnActualState;
        private Button btnExpirateBooks;
        private Button btnMoreBorrowings;
        private Button btnForTitle;
        private Label label2;
        private Button btnOut;
        private Button btnForAuthor;
        private Button btnForGender;
    }
}