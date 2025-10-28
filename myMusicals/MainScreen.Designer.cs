namespace myMusicals
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvTheaters = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            theaterBindingSource = new BindingSource(components);
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTheaters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)theaterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvTheaters
            // 
            dgvTheaters.AllowUserToAddRows = false;
            dgvTheaters.AllowUserToDeleteRows = false;
            dgvTheaters.AutoGenerateColumns = false;
            dgvTheaters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheaters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheaters.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn });
            dgvTheaters.DataSource = theaterBindingSource;
            dgvTheaters.Location = new Point(402, 12);
            dgvTheaters.Name = "dgvTheaters";
            dgvTheaters.ReadOnly = true;
            dgvTheaters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheaters.Size = new Size(386, 244);
            dgvTheaters.TabIndex = 0;
            dgvTheaters.CellDoubleClick += dgvTheaters_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 15F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Theater Name";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // theaterBindingSource
            // 
            theaterBindingSource.DataSource = typeof(Classes.Theater);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(617, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "neues Theater anlegen";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(dgvTheaters);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyMusicals";
            ((System.ComponentModel.ISupportInitialize)dgvTheaters).EndInit();
            ((System.ComponentModel.ISupportInitialize)theaterBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTheaters;
        private BindingSource theaterBindingSource;
        private Button btnAdd;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}
