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
            btnAddTheater = new Button();
            btnAddMusical = new Button();
            pTheaters = new Panel();
            pTheatersButtons = new Panel();
            pMusicals = new Panel();
            dGVMusicals = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            pMusicalsButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTheaters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)theaterBindingSource).BeginInit();
            pTheaters.SuspendLayout();
            pTheatersButtons.SuspendLayout();
            pMusicals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVMusicals).BeginInit();
            pMusicalsButtons.SuspendLayout();
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
            dgvTheaters.Dock = DockStyle.Fill;
            dgvTheaters.Location = new Point(0, 0);
            dgvTheaters.Margin = new Padding(0);
            dgvTheaters.Name = "dgvTheaters";
            dgvTheaters.ReadOnly = true;
            dgvTheaters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheaters.Size = new Size(320, 404);
            dgvTheaters.TabIndex = 0;
            dgvTheaters.CellClick += dgvTheaters_CellClick;
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
            // btnAddTheater
            // 
            btnAddTheater.Dock = DockStyle.Fill;
            btnAddTheater.Location = new Point(10, 10);
            btnAddTheater.Name = "btnAddTheater";
            btnAddTheater.Size = new Size(300, 29);
            btnAddTheater.TabIndex = 1;
            btnAddTheater.Text = "neues Theater anlegen";
            btnAddTheater.UseVisualStyleBackColor = true;
            btnAddTheater.Click += btnAddTheater_Click;
            // 
            // btnAddMusical
            // 
            btnAddMusical.Dock = DockStyle.Fill;
            btnAddMusical.Location = new Point(10, 10);
            btnAddMusical.Name = "btnAddMusical";
            btnAddMusical.Size = new Size(300, 29);
            btnAddMusical.TabIndex = 2;
            btnAddMusical.Text = "neues Musical anlegen";
            btnAddMusical.UseVisualStyleBackColor = true;
            btnAddMusical.Click += btnAddMusical_Click;
            // 
            // pTheaters
            // 
            pTheaters.Controls.Add(dgvTheaters);
            pTheaters.Controls.Add(pTheatersButtons);
            pTheaters.Dock = DockStyle.Left;
            pTheaters.Location = new Point(0, 0);
            pTheaters.Name = "pTheaters";
            pTheaters.Size = new Size(320, 453);
            pTheaters.TabIndex = 3;
            // 
            // pTheatersButtons
            // 
            pTheatersButtons.Controls.Add(btnAddTheater);
            pTheatersButtons.Dock = DockStyle.Bottom;
            pTheatersButtons.Location = new Point(0, 404);
            pTheatersButtons.Name = "pTheatersButtons";
            pTheatersButtons.Padding = new Padding(10);
            pTheatersButtons.Size = new Size(320, 49);
            pTheatersButtons.TabIndex = 3;
            // 
            // pMusicals
            // 
            pMusicals.Controls.Add(dGVMusicals);
            pMusicals.Controls.Add(pMusicalsButtons);
            pMusicals.Dock = DockStyle.Left;
            pMusicals.Location = new Point(320, 0);
            pMusicals.Name = "pMusicals";
            pMusicals.Size = new Size(320, 453);
            pMusicals.TabIndex = 4;
            // 
            // dGVMusicals
            // 
            dGVMusicals.AllowUserToAddRows = false;
            dGVMusicals.AllowUserToDeleteRows = false;
            dGVMusicals.AutoGenerateColumns = false;
            dGVMusicals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVMusicals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVMusicals.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dGVMusicals.DataSource = theaterBindingSource;
            dGVMusicals.Dock = DockStyle.Fill;
            dGVMusicals.Location = new Point(0, 0);
            dGVMusicals.Margin = new Padding(0);
            dGVMusicals.Name = "dGVMusicals";
            dGVMusicals.ReadOnly = true;
            dGVMusicals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVMusicals.Size = new Size(320, 404);
            dGVMusicals.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.FillWeight = 15F;
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            dataGridViewTextBoxColumn2.HeaderText = "Musical Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pMusicalsButtons
            // 
            pMusicalsButtons.Controls.Add(btnAddMusical);
            pMusicalsButtons.Dock = DockStyle.Bottom;
            pMusicalsButtons.Location = new Point(0, 404);
            pMusicalsButtons.Name = "pMusicalsButtons";
            pMusicalsButtons.Padding = new Padding(10);
            pMusicalsButtons.Size = new Size(320, 49);
            pMusicalsButtons.TabIndex = 0;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 453);
            Controls.Add(pMusicals);
            Controls.Add(pTheaters);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyMusicals";
            ((System.ComponentModel.ISupportInitialize)dgvTheaters).EndInit();
            ((System.ComponentModel.ISupportInitialize)theaterBindingSource).EndInit();
            pTheaters.ResumeLayout(false);
            pTheatersButtons.ResumeLayout(false);
            pMusicals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVMusicals).EndInit();
            pMusicalsButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTheaters;
        private BindingSource theaterBindingSource;
        private Button btnAddTheater;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private Button btnAddMusical;
        private Panel pTheaters;
        private Panel pTheatersButtons;
        private Panel pMusicals;
        private Panel pMusicalsButtons;
        private DataGridView dGVMusicals;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
