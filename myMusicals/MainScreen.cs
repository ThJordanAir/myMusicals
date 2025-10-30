using myMusicals.Classes;
using myMusicals.Services;
using myMusicals.Views;
using SQLitePCL;
using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace myMusicals
{
    public partial class MainScreen : Form
    {
        Theater mainTheater = new Theater();

        private bool isExpanded = true;
        private int fullWidth;
        private Timer slideTimer;
        private int step = 10;

        public MainScreen()
        {
            InitializeComponent();
            Batteries.Init(); // 👈 Do this first
            Database.Initialize();
            Theater.CreateTable();
            Musical.CreateTable();
            LoadTheaters();

            fullWidth = tcTheaters.Width;

            // Timer konfigurieren
            slideTimer = new Timer();
            slideTimer.Interval = 15;
            slideTimer.Tick += SlideTimer_Tick;

            // Button "heften"
            // btSlider1.Parent = tcTheaters;
            btSlider1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tcTheaters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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

        private void btSlider1_Click(object sender, EventArgs e)
        {
            if (!slideTimer.Enabled)
                slideTimer.Start();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                // Panel nach links "zusammenschieben"
                if (tcTheaters.Location.X <= (fullWidth * -1))
                {
                    tcTheaters.Visible = false;
                    slideTimer.Stop();
                    btSlider1.Text = "SHOW";
                    isExpanded = false;
                }
                else
                    // pTheaters.Location.X -= step;
                    tcTheaters.Location = new Point(tcTheaters.Location.X - step, tcTheaters.Location.Y);
            }
            else
            {
                tcTheaters.Visible = true;

                if (tcTheaters.Location.X < 0)
                {
                    tcTheaters.Location = new Point(tcTheaters.Location.X + step, tcTheaters.Location.Y);
                }
                else
                {
                    // Panel ist wieder an der ursprünglichen Position
                    tcTheaters.Location = new Point(0, tcTheaters.Location.Y);
                    slideTimer.Stop();
                    btSlider1.Text = "HIDE";
                    isExpanded = true;
                }
            }
            btSlider1.Location = new Point(tcTheaters.Location.X + fullWidth, btSlider1.Location.Y);
        }

        private void MainScreen_Resize(object sender, EventArgs e)
        {
            btSlider1.Location = new Point(tcTheaters.Location.X + fullWidth, btSlider1.Location.Y);
        }
    }
}
