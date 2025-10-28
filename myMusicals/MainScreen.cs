using myMusicals.Classes;
using myMusicals.Services;
using myMusicals.Views;
using SQLitePCL;
using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myMusicals
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Batteries.Init(); // 👈 Do this first
            Database.Initialize();
            Theater.CreateTable();
            Musical.CreateTable();
            LoadTheaters();
        }

        private void LoadTheaters()
        {
            // System.Diagnostics.Debug.WriteLine("jetzt LoadTheaters");
            var theaters = Theater.GetAll();
            dgvTheaters.DataSource = theaters;
        }
        private void LoadMusicals(Theater theater)
        {
            // System.Diagnostics.Debug.WriteLine("jetzt LoadTheaters");
            var musicals = Musical.GetAll(theater.Id);
            dGVMusicals.DataSource = musicals;
        }

        private void btnAddTheater_Click(object sender, EventArgs e)
        {
            Theater newTheater = new Theater()
            {
                Title = ""
            };
            TheaterMask newForm = new TheaterMask(newTheater);
            newForm.ShowDialog();
            LoadTheaters();
            dgvTheaters.Refresh();
        }

        private void dgvTheaters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTheaters.Rows[e.RowIndex];
            int theaterId = Convert.ToInt32(row.Cells[0].Value);

            Theater selectedTheater = Theater.Get(theaterId);
            TheaterMask form = new TheaterMask(selectedTheater);
            form.ShowDialog();
            LoadTheaters();
        }

        private void btnAddMusical_Click(object sender, EventArgs e)
        {
            if (dgvTheaters.CurrentRow == null || dgvTheaters.CurrentRow.Index < 0)
            {
                MessageBox.Show("Bitte wähle erst ein Theater aus!");
                return;
            }

        }

        private void dgvTheaters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTheaters.Rows[e.RowIndex];
            int theaterId = Convert.ToInt32(row.Cells[0].Value);

            Theater selectedTheater = Theater.Get(theaterId);
            LoadMusicals(selectedTheater);
        }
    }
}
