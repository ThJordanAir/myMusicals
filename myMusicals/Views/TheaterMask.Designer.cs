namespace myMusicals.Views
{
    partial class TheaterMask
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
            tbTheaterName = new TextBox();
            btDelete = new Button();
            btSave = new Button();
            nUDRows = new NumericUpDown();
            nUDSeats = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nUDRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDSeats).BeginInit();
            SuspendLayout();
            // 
            // tbTheaterName
            // 
            tbTheaterName.Location = new Point(12, 12);
            tbTheaterName.Name = "tbTheaterName";
            tbTheaterName.Size = new Size(330, 23);
            tbTheaterName.TabIndex = 0;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(12, 191);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 1;
            btDelete.Text = "löschen";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(267, 191);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 2;
            btSave.Text = "speichern";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // nUDRows
            // 
            nUDRows.Location = new Point(77, 41);
            nUDRows.Name = "nUDRows";
            nUDRows.Size = new Size(120, 23);
            nUDRows.TabIndex = 3;
            // 
            // nUDSeats
            // 
            nUDSeats.Location = new Point(77, 70);
            nUDSeats.Name = "nUDSeats";
            nUDSeats.Size = new Size(120, 23);
            nUDSeats.TabIndex = 4;
            // 
            // TheaterMask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 287);
            Controls.Add(nUDSeats);
            Controls.Add(nUDRows);
            Controls.Add(btSave);
            Controls.Add(btDelete);
            Controls.Add(tbTheaterName);
            Name = "TheaterMask";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Theater";
            Load += TheaterMask_Load;
            ((System.ComponentModel.ISupportInitialize)nUDRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDSeats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTheaterName;
        private Button btDelete;
        private Button btSave;
        private NumericUpDown nUDRows;
        private NumericUpDown nUDSeats;
    }
}