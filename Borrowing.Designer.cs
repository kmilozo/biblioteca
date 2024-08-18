namespace biblioteca
{
    partial class Borrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrowing));
            label1 = new Label();
            cmbReader = new ComboBox();
            cmbBook = new ComboBox();
            dtBorrowing = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            dtExpire = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 20);
            label1.Name = "label1";
            label1.Size = new Size(294, 26);
            label1.TabIndex = 0;
            label1.Text = "Registro de prestamos de libros";
            // 
            // cmbReader
            // 
            cmbReader.FormattingEnabled = true;
            cmbReader.Location = new Point(162, 100);
            cmbReader.Margin = new Padding(3, 2, 3, 2);
            cmbReader.Name = "cmbReader";
            cmbReader.Size = new Size(219, 23);
            cmbReader.TabIndex = 1;
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(162, 154);
            cmbBook.Margin = new Padding(3, 2, 3, 2);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(219, 23);
            cmbBook.TabIndex = 2;
            // 
            // dtBorrowing
            // 
            dtBorrowing.Format = DateTimePickerFormat.Custom;
            dtBorrowing.Location = new Point(162, 212);
            dtBorrowing.Margin = new Padding(3, 2, 3, 2);
            dtBorrowing.Name = "dtBorrowing";
            dtBorrowing.Size = new Size(219, 23);
            dtBorrowing.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 102);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Lector";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 269);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha vencimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 217);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha presramo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 160);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 8;
            label5.Text = "Libro";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(38, 319);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 9;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(38, 357);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtExpire
            // 
            dtExpire.Format = DateTimePickerFormat.Short;
            dtExpire.Location = new Point(162, 264);
            dtExpire.Margin = new Padding(3, 2, 3, 2);
            dtExpire.Name = "dtExpire";
            dtExpire.Size = new Size(219, 23);
            dtExpire.TabIndex = 11;
            // 
            // Borrowing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(528, 395);
            Controls.Add(dtExpire);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtBorrowing);
            Controls.Add(cmbBook);
            Controls.Add(cmbReader);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Borrowing";
            Text = "Borrowing";
            Load += Borrowing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbReader;
        private ComboBox cmbBook;
        private DateTimePicker dtBorrowing;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtExpire;
    }
}