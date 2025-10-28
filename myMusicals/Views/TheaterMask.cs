using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myMusicals.Classes;

namespace myMusicals.Views
{
    public partial class TheaterMask : Form
    {
        private Theater _theater;
        public TheaterMask(Theater theater)
        {
            InitializeComponent();
            _theater = theater;
        }

        private void TheaterMask_Load(object sender, EventArgs e)
        {
            /*
                        lblName.Text = _person.Name;
                        lblAlter.Text = _person.Alter.ToString();
            */
            tbTheaterName.Text = _theater.Title;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _theater.Title = tbTheaterName.Text;
            _theater.Save();
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (_theater.Id != 0)
            {
                Theater.Delete(_theater.Id);
                this.Close();
            }
        }
    }
}
