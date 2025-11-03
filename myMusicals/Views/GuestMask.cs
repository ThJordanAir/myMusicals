using myMusicals.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myMusicals.Views
{
    public partial class GuestMask : Form
    {
        private Guest _guest;

        public GuestMask(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
        }

        private void GuestMask_Load(object sender, EventArgs e)
        {
            tbGuestName.Text = _guest.Name;
            tbGuestPhone.Text = _guest.Phone;
            tbGuestEMail.Text = _guest.EMail;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _guest.Name = tbGuestName.Text;
            _guest.Phone = tbGuestPhone.Text;
            _guest.EMail = tbGuestEMail.Text;
            _guest.Save();
            this.Close();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (_guest.Id != 0)
            {
                Guest.Delete(_guest.Id);
                this.Close();
            }

        }

    }
}
