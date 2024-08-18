namespace biblioteca
{
    partial class SeeForTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeForTitle));
            btnSearch = new Button();
            dgvReportTitle = new DataGridView();
            btnOut = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportTitle).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(451, 52);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 22);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvReportTitle
            // 
            dgvReportTitle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportTitle.Location = new Point(22, 99);
            dgvReportTitle.Margin = new Padding(3, 2, 3, 2);
            dgvReportTitle.Name = "dgvReportTitle";
            dgvReportTitle.RowHeadersWidth = 51;
            dgvReportTitle.Size = new Size(576, 192);
            dgvReportTitle.TabIndex = 36;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(518, 325);
            btnOut.Margin = new Padding(3, 2, 3, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(80, 22);
            btnOut.TabIndex = 35;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 15);
            label1.Name = "label1";
            label1.Size = new Size(190, 26);
            label1.TabIndex = 34;
            label1.Text = "Consultas por titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 59);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 33;
            label2.Text = "Ingrese el titulo del libro";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(178, 52);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(268, 23);
            txtTitle.TabIndex = 38;
            // 
            // SeeForTitle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(624, 404);
            Controls.Add(txtTitle);
            Controls.Add(btnSearch);
            Controls.Add(dgvReportTitle);
            Controls.Add(btnOut);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeeForTitle";
            Text = "SeeForTitle";
            Load += SeeForTitle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvReportTitle;
        private Button btnOut;
        private Label label1;
        private Label label2;
        private TextBox txtTitle;
    }
}