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
            LoadTheaters();
        }

        private void LoadTheaters()
        {
            // System.Diagnostics.Debug.WriteLine("jetzt LoadTheaters");
            var theaters = Theater.GetAll();
            dgvTheaters.DataSource = theaters;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            // Ignoriere Header-Klicks
            if (e.RowIndex < 0)
                return;

            // Hole den ausgewählten Datensatz
            var row = dgvTheaters.Rows[e.RowIndex];
            int theaterId = Convert.ToInt32(row.Cells[0].Value);
            string title = row.Cells[1].Value.ToString();

            // Theater-Objekt erstellen oder laden
            Theater selectedTheater = new Theater
            {
                Id = theaterId,
                Title = title
            };

            // Detail- oder Bearbeitungsfenster öffnen
            TheaterMask form = new TheaterMask(selectedTheater);
            form.ShowDialog();

            // Nach dem Schließen ggf. neu laden:
            LoadTheaters();
        }
    }
}
