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
    public partial class MusicalMask : Form
    {
        private Theater _theater;
        private Musical _musical;

        public MusicalMask(Musical musical, Theater theater)
        {
            InitializeComponent();
            _theater = theater;
            _musical = musical;
        }

        private void MusicalMask_Load(object sender, EventArgs e)
        {
            lTheaterName.Text = _theater.Title;
            tbMusicalName.Text = _musical.Title;
            nUDPrice.Value = (decimal)_musical.Price;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _musical.Title = tbMusicalName.Text;
            _musical.Price = (double)nUDPrice.Value;
            _musical.TheaterId = _theater.Id;
            _musical.Save();
            this.Close();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (_musical.Id != 0)
            {
                Musical.Delete(_musical.Id);
                this.Close();
            }

        }
    }
}
