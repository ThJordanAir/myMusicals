namespace myMusicals.Views
{
    partial class GuestMask
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
            btSave = new Button();
            btDelete = new Button();
            tbGuestName = new TextBox();
            tbGuestPhone = new TextBox();
            tbGuestEMail = new TextBox();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Location = new Point(180, 71);
            btSave.Name = "btSave";
            btSave.Size = new Size(162, 23);
            btSave.TabIndex = 4;
            btSave.Text = "speichern";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(12, 71);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(162, 23);
            btDelete.TabIndex = 5;
            btDelete.Text = "löschen";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // tbGuestName
            // 
            tbGuestName.Location = new Point(12, 13);
            tbGuestName.Name = "tbGuestName";
            tbGuestName.Size = new Size(330, 23);
            tbGuestName.TabIndex = 1;
            // 
            // tbGuestPhone
            // 
            tbGuestPhone.Location = new Point(12, 42);
            tbGuestPhone.Name = "tbGuestPhone";
            tbGuestPhone.Size = new Size(162, 23);
            tbGuestPhone.TabIndex = 2;
            // 
            // tbGuestEMail
            // 
            tbGuestEMail.Location = new Point(180, 42);
            tbGuestEMail.Name = "tbGuestEMail";
            tbGuestEMail.Size = new Size(162, 23);
            tbGuestEMail.TabIndex = 3;
            // 
            // GuestMask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 106);
            Controls.Add(tbGuestName);
            Controls.Add(tbGuestPhone);
            Controls.Add(tbGuestEMail);
            Controls.Add(btSave);
            Controls.Add(btDelete);
            Name = "GuestMask";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kunden";
            Load += GuestMask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private Button btDelete;
        private TextBox tbGuestName;
        private TextBox tbGuestPhone;
        private TextBox tbGuestEMail;
    }
}