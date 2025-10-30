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
            Rows = new DataGridViewTextBoxColumn();
            Seats = new DataGridViewTextBoxColumn();
            theaterBindingSource = new BindingSource(components);
            btnAddTheater = new Button();
            btnAddMusical = new Button();
            pTheaters = new Panel();
            pTheatersButtons = new Panel();
            pMusicals = new Panel();
            dGVMusicals = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            musicalBindingSource = new BindingSource(components);
            pMusicalsButtons = new Panel();
            tcTheaters = new TabControl();
            tpTheater = new TabPage();
            tpMusical = new TabPage();
            btSlider1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTheaters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)theaterBindingSource).BeginInit();
            pTheaters.SuspendLayout();
            pTheatersButtons.SuspendLayout();
            pMusicals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVMusicals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)musicalBindingSource).BeginInit();
            pMusicalsButtons.SuspendLayout();
            tcTheaters.SuspendLayout();
            tpTheater.SuspendLayout();
            tpMusical.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTheaters
            // 
            dgvTheaters.AllowUserToAddRows = false;
            dgvTheaters.AllowUserToDeleteRows = false;
            dgvTheaters.AutoGenerateColumns = false;
            dgvTheaters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheaters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheaters.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, Rows, Seats });
            dgvTheaters.DataSource = theaterBindingSource;
            dgvTheaters.Dock = DockStyle.Fill;
            dgvTheaters.Location = new Point(0, 0);
            dgvTheaters.Margin = new Padding(0);
            dgvTheaters.Name = "dgvTheaters";
            dgvTheaters.ReadOnly = true;
            dgvTheaters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheaters.Size = new Size(436, 390);
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
            titleDataGridViewTextBoxColumn.FillWeight = 50F;
            titleDataGridViewTextBoxColumn.HeaderText = "Theater Name";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Rows
            // 
            Rows.DataPropertyName = "Rows";
            Rows.FillWeight = 15F;
            Rows.HeaderText = "Reihen";
            Rows.Name = "Rows";
            Rows.ReadOnly = true;
            // 
            // Seats
            // 
            Seats.DataPropertyName = "Seats";
            Seats.FillWeight = 15F;
            Seats.HeaderText = "Sitze";
            Seats.Name = "Seats";
            Seats.ReadOnly = true;
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
            btnAddTheater.Size = new Size(416, 29);
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
            btnAddMusical.Size = new Size(416, 29);
            btnAddMusical.TabIndex = 2;
            btnAddMusical.Text = "neues Musical anlegen";
            btnAddMusical.UseVisualStyleBackColor = true;
            btnAddMusical.Click += btnAddMusical_Click;
            // 
            // pTheaters
            // 
            pTheaters.Controls.Add(dgvTheaters);
            pTheaters.Controls.Add(pTheatersButtons);
            pTheaters.Dock = DockStyle.Fill;
            pTheaters.Location = new Point(3, 3);
            pTheaters.Name = "pTheaters";
            pTheaters.Size = new Size(436, 439);
            pTheaters.TabIndex = 3;
            // 
            // pTheatersButtons
            // 
            pTheatersButtons.Controls.Add(btnAddTheater);
            pTheatersButtons.Dock = DockStyle.Bottom;
            pTheatersButtons.Location = new Point(0, 390);
            pTheatersButtons.Name = "pTheatersButtons";
            pTheatersButtons.Padding = new Padding(10);
            pTheatersButtons.Size = new Size(436, 49);
            pTheatersButtons.TabIndex = 3;
            // 
            // pMusicals
            // 
            pMusicals.Controls.Add(dGVMusicals);
            pMusicals.Controls.Add(pMusicalsButtons);
            pMusicals.Dock = DockStyle.Fill;
            pMusicals.Location = new Point(3, 3);
            pMusicals.Name = "pMusicals";
            pMusicals.Size = new Size(436, 439);
            pMusicals.TabIndex = 4;
            // 
            // dGVMusicals
            // 
            dGVMusicals.AllowUserToAddRows = false;
            dGVMusicals.AllowUserToDeleteRows = false;
            dGVMusicals.AutoGenerateColumns = false;
            dGVMusicals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVMusicals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVMusicals.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Price });
            dGVMusicals.DataSource = musicalBindingSource;
            dGVMusicals.Dock = DockStyle.Fill;
            dGVMusicals.Location = new Point(0, 0);
            dGVMusicals.Margin = new Padding(0);
            dGVMusicals.Name = "dGVMusicals";
            dGVMusicals.ReadOnly = true;
            dGVMusicals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVMusicals.Size = new Size(436, 390);
            dGVMusicals.TabIndex = 1;
            dGVMusicals.CellDoubleClick += dGVMusicals_CellDoubleClick;
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
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.FillWeight = 25F;
            Price.HeaderText = "Preis";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // musicalBindingSource
            // 
            musicalBindingSource.DataSource = typeof(Classes.Musical);
            // 
            // pMusicalsButtons
            // 
            pMusicalsButtons.Controls.Add(btnAddMusical);
            pMusicalsButtons.Dock = DockStyle.Bottom;
            pMusicalsButtons.Location = new Point(0, 390);
            pMusicalsButtons.Name = "pMusicalsButtons";
            pMusicalsButtons.Padding = new Padding(10);
            pMusicalsButtons.Size = new Size(436, 49);
            pMusicalsButtons.TabIndex = 0;
            // 
            // tcTheaters
            // 
            tcTheaters.Controls.Add(tpTheater);
            tcTheaters.Controls.Add(tpMusical);
            tcTheaters.Location = new Point(0, 0);
            tcTheaters.Name = "tcTheaters";
            tcTheaters.SelectedIndex = 0;
            tcTheaters.Size = new Size(450, 473);
            tcTheaters.TabIndex = 5;
            // 
            // tpTheater
            // 
            tpTheater.Controls.Add(pTheaters);
            tpTheater.Location = new Point(4, 24);
            tpTheater.Name = "tpTheater";
            tpTheater.Padding = new Padding(3);
            tpTheater.Size = new Size(442, 445);
            tpTheater.TabIndex = 0;
            tpTheater.Text = "Theater";
            tpTheater.UseVisualStyleBackColor = true;
            // 
            // tpMusical
            // 
            tpMusical.Controls.Add(pMusicals);
            tpMusical.Location = new Point(4, 24);
            tpMusical.Name = "tpMusical";
            tpMusical.Padding = new Padding(3);
            tpMusical.Size = new Size(442, 445);
            tpMusical.TabIndex = 1;
            tpMusical.Text = "Musicals";
            tpMusical.UseVisualStyleBackColor = true;
            // 
            // btSlider1
            // 
            btSlider1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSlider1.Location = new Point(449, 0);
            btSlider1.Name = "btSlider1";
            btSlider1.Size = new Size(20, 138);
            btSlider1.TabIndex = 6;
            btSlider1.Text = "HIDE";
            btSlider1.UseVisualStyleBackColor = true;
            btSlider1.Click += btSlider1_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 473);
            Controls.Add(btSlider1);
            Controls.Add(tcTheaters);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyMusicals";
            Resize += MainScreen_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvTheaters).EndInit();
            ((System.ComponentModel.ISupportInitialize)theaterBindingSource).EndInit();
            pTheaters.ResumeLayout(false);
            pTheatersButtons.ResumeLayout(false);
            pMusicals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVMusicals).EndInit();
            ((System.ComponentModel.ISupportInitialize)musicalBindingSource).EndInit();
            pMusicalsButtons.ResumeLayout(false);
            tcTheaters.ResumeLayout(false);
            tpTheater.ResumeLayout(false);
            tpMusical.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTheaters;
        private BindingSource theaterBindingSource;
        private Button btnAddTheater;
        private Button btnAddMusical;
        private Panel pTheaters;
        private Panel pTheatersButtons;
        private Panel pMusicals;
        private Panel pMusicalsButtons;
        private DataGridView dGVMusicals;
        private TabControl tcTheaters;
        private TabPage tpTheater;
        private TabPage tpMusical;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Rows;
        private DataGridViewTextBoxColumn Seats;
        private BindingSource musicalBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Price;
        private Button btSlider1;
    }
}
