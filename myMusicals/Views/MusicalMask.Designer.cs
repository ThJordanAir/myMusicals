namespace myMusicals.Views
{
    partial class MusicalMask
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
            tbMusicalName = new TextBox();
            lPrice = new Label();
            nUDPrice = new NumericUpDown();
            btSave = new Button();
            btDelete = new Button();
            lTheaterName = new Label();
            ((System.ComponentModel.ISupportInitialize)nUDPrice).BeginInit();
            SuspendLayout();
            // 
            // tbMusicalName
            // 
            tbMusicalName.Location = new Point(12, 12);
            tbMusicalName.Name = "tbMusicalName";
            tbMusicalName.Size = new Size(330, 23);
            tbMusicalName.TabIndex = 1;
            // 
            // lPrice
            // 
            lPrice.AutoSize = true;
            lPrice.Location = new Point(183, 43);
            lPrice.Name = "lPrice";
            lPrice.Size = new Size(32, 15);
            lPrice.TabIndex = 8;
            lPrice.Text = "Preis";
            // 
            // nUDPrice
            // 
            nUDPrice.DecimalPlaces = 2;
            nUDPrice.Location = new Point(264, 41);
            nUDPrice.Name = "nUDPrice";
            nUDPrice.Size = new Size(78, 23);
            nUDPrice.TabIndex = 7;
            // 
            // btSave
            // 
            btSave.Location = new Point(180, 70);
            btSave.Name = "btSave";
            btSave.Size = new Size(162, 23);
            btSave.TabIndex = 10;
            btSave.Text = "speichern";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(12, 70);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(162, 23);
            btDelete.TabIndex = 9;
            btDelete.Text = "löschen";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // lTheaterName
            // 
            lTheaterName.AutoSize = true;
            lTheaterName.Location = new Point(12, 43);
            lTheaterName.Name = "lTheaterName";
            lTheaterName.Size = new Size(38, 15);
            lTheaterName.TabIndex = 11;
            lTheaterName.Text = "label1";
            // 
            // MusicalMask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 106);
            Controls.Add(lTheaterName);
            Controls.Add(btSave);
            Controls.Add(btDelete);
            Controls.Add(lPrice);
            Controls.Add(nUDPrice);
            Controls.Add(tbMusicalName);
            Name = "MusicalMask";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MusicalMask";
            Load += MusicalMask_Load;
            ((System.ComponentModel.ISupportInitialize)nUDPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMusicalName;
        private Label lPrice;
        private NumericUpDown nUDPrice;
        private Button btSave;
        private Button btDelete;
        private Label lTheaterName;
    }
}