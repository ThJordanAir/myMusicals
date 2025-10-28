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
        Theater mainTheater = new Theater();
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
        private void LoadMusicals()
        {
            // System.Diagnostics.Debug.WriteLine("jetzt LoadTheaters");
            if (mainTheater.Id > 0)
            {
                var musicals = Musical.GetAll(mainTheater.Id);
                dGVMusicals.DataSource = musicals;
            }
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
            if (
                mainTheater.Id > 0
            )
            {
                Musical newMusical = new Musical()
                {
                    Title = ""
                };
                MusicalMask form = new MusicalMask(newMusical, mainTheater);
                form.ShowDialog();
                LoadMusicals();

                return;
            }
            MessageBox.Show("Bitte wähle erst ein Theater aus!");
            return;
        }

        private void dgvTheaters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTheaters.Rows[e.RowIndex];
            int theaterId = Convert.ToInt32(row.Cells[0].Value);
            mainTheater = Theater.Get(theaterId);
            LoadMusicals();
        }

        private void dGVMusicals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            var row = dGVMusicals.Rows[e.RowIndex];
            int musicalId = Convert.ToInt32(row.Cells[0].Value);

            Musical selectedMusical = Musical.Get(musicalId);

            MusicalMask form = new MusicalMask(selectedMusical, mainTheater);
            form.ShowDialog();
            LoadMusicals();
        }
    }
}
