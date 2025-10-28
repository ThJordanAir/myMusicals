using myMusicals.Classes;
using myMusicals.Services;
using myMusicals.Views;
using SQLitePCL;
using System;
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
            System.Diagnostics.Debug.WriteLine("jetzt LoadTheaters");
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
            System.Diagnostics.Debug.WriteLine("jetzt 1");
            newForm.ShowDialog();
            System.Diagnostics.Debug.WriteLine("jetzt 2");
            LoadTheaters();
            System.Diagnostics.Debug.WriteLine("jetzt 3");
            dgvTheaters.Refresh();
            System.Diagnostics.Debug.WriteLine("jetzt 4");
        }
    }
}
