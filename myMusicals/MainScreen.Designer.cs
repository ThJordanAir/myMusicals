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
            tcCustomers = new TabControl();
            tpCustomer = new TabPage();
            pCustomer = new Panel();
            dgvGuests = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eMailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestBindingSource = new BindingSource(components);
            pCutsomerButtons = new Panel();
            btnAddCutomer = new Button();
            tabPage2 = new TabPage();
            titleDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            theaterIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btSlider2 = new Button();
            pSeatControll = new Panel();
            pSeats = new Panel();
            pSeatsButtons = new Panel();
            cbSlider2 = new CheckBox();
            cbSlider1 = new CheckBox();
            lMusicalName = new Label();
            lTheaterName = new Label();
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
            tcCustomers.SuspendLayout();
            tpCustomer.SuspendLayout();
            pCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestBindingSource).BeginInit();
            pCutsomerButtons.SuspendLayout();
            pSeatControll.SuspendLayout();
            pSeatsButtons.SuspendLayout();
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
            dGVMusicals.CellClick += dGVMusicals_CellClick;
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
            btSlider1.Anchor = AnchorStyles.None;
            btSlider1.Location = new Point(452, 0);
            btSlider1.Name = "btSlider1";
            btSlider1.Size = new Size(20, 138);
            btSlider1.TabIndex = 6;
            btSlider1.Text = "HIDE";
            btSlider1.UseVisualStyleBackColor = true;
            btSlider1.Click += btSlider1_Click;
            // 
            // tcCustomers
            // 
            tcCustomers.Controls.Add(tpCustomer);
            tcCustomers.Controls.Add(tabPage2);
            tcCustomers.Location = new Point(634, 0);
            tcCustomers.Name = "tcCustomers";
            tcCustomers.SelectedIndex = 0;
            tcCustomers.Size = new Size(450, 473);
            tcCustomers.TabIndex = 7;
            // 
            // tpCustomer
            // 
            tpCustomer.Controls.Add(pCustomer);
            tpCustomer.Location = new Point(4, 24);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Padding = new Padding(3);
            tpCustomer.Size = new Size(442, 445);
            tpCustomer.TabIndex = 0;
            tpCustomer.Text = "Kunden";
            tpCustomer.UseVisualStyleBackColor = true;
            // 
            // pCustomer
            // 
            pCustomer.Controls.Add(dgvGuests);
            pCustomer.Controls.Add(pCutsomerButtons);
            pCustomer.Dock = DockStyle.Fill;
            pCustomer.Location = new Point(3, 3);
            pCustomer.Name = "pCustomer";
            pCustomer.Size = new Size(436, 439);
            pCustomer.TabIndex = 3;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dgvGuests.AutoGenerateColumns = false;
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuests.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, eMailDataGridViewTextBoxColumn });
            dgvGuests.DataSource = guestBindingSource;
            dgvGuests.Dock = DockStyle.Fill;
            dgvGuests.Location = new Point(0, 0);
            dgvGuests.Margin = new Padding(0);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.Size = new Size(436, 390);
            dgvGuests.TabIndex = 2;
            dgvGuests.CellClick += dgvGuests_CellClick;
            dgvGuests.CellDoubleClick += dgvGuests_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestBindingSource
            // 
            guestBindingSource.DataSource = typeof(Classes.Guest);
            // 
            // pCutsomerButtons
            // 
            pCutsomerButtons.Controls.Add(btnAddCutomer);
            pCutsomerButtons.Dock = DockStyle.Bottom;
            pCutsomerButtons.Location = new Point(0, 390);
            pCutsomerButtons.Name = "pCutsomerButtons";
            pCutsomerButtons.Padding = new Padding(10);
            pCutsomerButtons.Size = new Size(436, 49);
            pCutsomerButtons.TabIndex = 1;
            // 
            // btnAddCutomer
            // 
            btnAddCutomer.Dock = DockStyle.Fill;
            btnAddCutomer.Location = new Point(10, 10);
            btnAddCutomer.Name = "btnAddCutomer";
            btnAddCutomer.Size = new Size(416, 29);
            btnAddCutomer.TabIndex = 2;
            btnAddCutomer.Text = "neuen Kunden anlegen";
            btnAddCutomer.UseVisualStyleBackColor = true;
            btnAddCutomer.Click += btnAddCutomer_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(442, 445);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            // 
            // theaterIdDataGridViewTextBoxColumn
            // 
            theaterIdDataGridViewTextBoxColumn.DataPropertyName = "TheaterId";
            theaterIdDataGridViewTextBoxColumn.HeaderText = "TheaterId";
            theaterIdDataGridViewTextBoxColumn.Name = "theaterIdDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // btSlider2
            // 
            btSlider2.Anchor = AnchorStyles.None;
            btSlider2.Location = new Point(614, 0);
            btSlider2.Name = "btSlider2";
            btSlider2.Size = new Size(20, 138);
            btSlider2.TabIndex = 8;
            btSlider2.Text = "HIDE";
            btSlider2.UseVisualStyleBackColor = true;
            btSlider2.Click += btSlider2_Click;
            // 
            // pSeatControll
            // 
            pSeatControll.Controls.Add(pSeats);
            pSeatControll.Controls.Add(pSeatsButtons);
            pSeatControll.Dock = DockStyle.Fill;
            pSeatControll.Location = new Point(0, 0);
            pSeatControll.Margin = new Padding(0);
            pSeatControll.Name = "pSeatControll";
            pSeatControll.Padding = new Padding(30, 0, 30, 0);
            pSeatControll.Size = new Size(1084, 466);
            pSeatControll.TabIndex = 9;
            // 
            // pSeats
            // 
            pSeats.BackColor = Color.Transparent;
            pSeats.Dock = DockStyle.Fill;
            pSeats.Location = new Point(30, 39);
            pSeats.Name = "pSeats";
            pSeats.Size = new Size(1024, 427);
            pSeats.TabIndex = 0;
            pSeats.SizeChanged += pSeats_SizeChanged;
            // 
            // pSeatsButtons
            // 
            pSeatsButtons.Controls.Add(cbSlider2);
            pSeatsButtons.Controls.Add(cbSlider1);
            pSeatsButtons.Controls.Add(lMusicalName);
            pSeatsButtons.Controls.Add(lTheaterName);
            pSeatsButtons.Dock = DockStyle.Top;
            pSeatsButtons.Location = new Point(30, 0);
            pSeatsButtons.Name = "pSeatsButtons";
            pSeatsButtons.Size = new Size(1024, 39);
            pSeatsButtons.TabIndex = 0;
            // 
            // cbSlider2
            // 
            cbSlider2.AutoSize = true;
            cbSlider2.Location = new Point(950, 12);
            cbSlider2.Name = "cbSlider2";
            cbSlider2.Size = new Size(61, 19);
            cbSlider2.TabIndex = 3;
            cbSlider2.Text = "Rechts";
            cbSlider2.UseVisualStyleBackColor = true;
            cbSlider2.CheckedChanged += cbSlider2_CheckedChanged;
            // 
            // cbSlider1
            // 
            cbSlider1.AutoSize = true;
            cbSlider1.Location = new Point(891, 12);
            cbSlider1.Name = "cbSlider1";
            cbSlider1.Size = new Size(53, 19);
            cbSlider1.TabIndex = 2;
            cbSlider1.Text = "Links";
            cbSlider1.UseVisualStyleBackColor = true;
            cbSlider1.CheckedChanged += cbSlider1_CheckedChanged;
            // 
            // lMusicalName
            // 
            lMusicalName.AutoSize = true;
            lMusicalName.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            lMusicalName.Location = new Point(104, 4);
            lMusicalName.Name = "lMusicalName";
            lMusicalName.Size = new Size(91, 32);
            lMusicalName.TabIndex = 1;
            lMusicalName.Text = "Musical";
            // 
            // lTheaterName
            // 
            lTheaterName.AutoSize = true;
            lTheaterName.Font = new Font("Segoe UI", 18F, FontStyle.Underline);
            lTheaterName.Location = new Point(3, 4);
            lTheaterName.Name = "lTheaterName";
            lTheaterName.Size = new Size(95, 32);
            lTheaterName.TabIndex = 0;
            lTheaterName.Text = "Theater";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 466);
            Controls.Add(tcTheaters);
            Controls.Add(tcCustomers);
            Controls.Add(pSeatControll);
            Controls.Add(btSlider2);
            Controls.Add(btSlider1);
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
            tcCustomers.ResumeLayout(false);
            tpCustomer.ResumeLayout(false);
            pCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestBindingSource).EndInit();
            pCutsomerButtons.ResumeLayout(false);
            pSeatControll.ResumeLayout(false);
            pSeatsButtons.ResumeLayout(false);
            pSeatsButtons.PerformLayout();
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
        private TabControl tcCustomers;
        private TabPage tpCustomer;
        private TabPage tabPage2;
        private Button btSlider2;
        private Panel pSeatControll;
        private Panel pSeats;
        private Panel pSeatsButtons;
        private Label lMusicalName;
        private Label lTheaterName;
        private CheckBox cbSlider2;
        private CheckBox cbSlider1;
        private BindingSource guestBindingSource;
        private Panel pCutsomerButtons;
        private Button btnAddCutomer;
        private Panel pCustomer;
        private DataGridView dgvGuests;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn theaterIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
    }
}
