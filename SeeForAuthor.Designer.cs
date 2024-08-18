namespace biblioteca
{
    partial class SeeForAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeForAuthor));
            label2 = new Label();
            label1 = new Label();
            btnOut = new Button();
            dgvReportAuthor = new DataGridView();
            btnSearch = new Button();
            txtAutor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportAuthor).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 7;
            label2.Text = "Ingrese el autor a consultar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 40);
            label1.Name = "label1";
            label1.Size = new Size(189, 26);
            label1.TabIndex = 8;
            label1.Text = "Consultas por autor";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(521, 350);
            btnOut.Margin = new Padding(3, 2, 3, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(80, 22);
            btnOut.TabIndex = 29;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // dgvReportAuthor
            // 
            dgvReportAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportAuthor.Location = new Point(24, 124);
            dgvReportAuthor.Margin = new Padding(3, 2, 3, 2);
            dgvReportAuthor.Name = "dgvReportAuthor";
            dgvReportAuthor.RowHeadersWidth = 51;
            dgvReportAuthor.Size = new Size(576, 192);
            dgvReportAuthor.TabIndex = 30;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(445, 78);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 22);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(210, 80);
            txtAutor.Margin = new Padding(3, 2, 3, 2);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(218, 23);
            txtAutor.TabIndex = 32;
            // 
            // SeeForAuthor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(626, 454);
            Controls.Add(txtAutor);
            Controls.Add(btnSearch);
            Controls.Add(dgvReportAuthor);
            Controls.Add(btnOut);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeeForAuthor";
            Text = "SeeForAuthor";
            Load += SeeForAuthor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportAuthor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnOut;
        private DataGridView dgvReportAuthor;
        private Button btnSearch;
        private TextBox txtAutor;
    }
}