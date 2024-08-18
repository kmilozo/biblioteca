namespace biblioteca
{
    partial class SeeForGender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeForGender));
            btnSearch = new Button();
            dgvReportGender = new DataGridView();
            btnOut = new Button();
            label1 = new Label();
            label2 = new Label();
            txtGender = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportGender).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(451, 58);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 22);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvReportGender
            // 
            dgvReportGender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportGender.Location = new Point(22, 101);
            dgvReportGender.Margin = new Padding(3, 2, 3, 2);
            dgvReportGender.Name = "dgvReportGender";
            dgvReportGender.RowHeadersWidth = 51;
            dgvReportGender.Size = new Size(576, 192);
            dgvReportGender.TabIndex = 36;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(518, 327);
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
            label1.Location = new Point(169, 17);
            label1.Name = "label1";
            label1.Size = new Size(203, 26);
            label1.TabIndex = 34;
            label1.Text = "Consultas por genero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 62);
            label2.Name = "label2";
            label2.Size = new Size(201, 15);
            label2.TabIndex = 33;
            label2.Text = "Ingrese el genero literario a consultar";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(251, 59);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(178, 23);
            txtGender.TabIndex = 38;
            // 
            // SeeForGender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(620, 397);
            Controls.Add(txtGender);
            Controls.Add(btnSearch);
            Controls.Add(dgvReportGender);
            Controls.Add(btnOut);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeeForGender";
            Text = "SeeForGender";
            ((System.ComponentModel.ISupportInitialize)dgvReportGender).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvReportGender;
        private Button btnOut;
        private Label label1;
        private Label label2;
        private TextBox txtGender;
    }
}