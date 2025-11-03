using myMusicals.Classes;
using myMusicals.Services;
using myMusicals.Views;
using SQLitePCL;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Timer = System.Windows.Forms.Timer;

namespace myMusicals
{
    public partial class MainScreen : Form
    {
        Theater mainTheater = new Theater();
        Musical mainMusical = new Musical();
        //private Theater _theater;
        //private Musical _musical;

        private bool useTimer1 = false;
        private bool isExpanded1 = true;
        private int fullWidth1;
        private Timer slideTimer1;
        private bool useTimer2 = true;
        private bool isExpanded2 = true;
        private int fullWidth2;
        private Timer slideTimer2;
        private int step = 2;

        private Button[,] mainSeats;

        public MainScreen()
        {
            InitializeComponent();
            Batteries.Init(); // 👈 Do this first
            Database.Initialize();
            Theater.CreateTable();
            Musical.CreateTable();
            Guest.CreateTable();
            LoadTheaters();

            tcCustomers.BringToFront();
            tcTheaters.BringToFront();
            btSlider1.BringToFront();
            btSlider2.BringToFront();


            fullWidth1 = tcTheaters.Width;
            fullWidth2 = tcCustomers.Width;

            // Timer konfigurieren
            slideTimer1 = new Timer();
            slideTimer1.Interval = 1;
            slideTimer1.Tick += SlideTimer1_Tick;
            slideTimer2 = new Timer();
            slideTimer2.Interval = 1;
            slideTimer2.Tick += SlideTimer2_Tick;

            // Button "heften"
            // btSlider1.Parent = tcTheaters;
            // btSlider1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tcTheaters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tcCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            lTheaterName.Text = mainTheater.Title;
            lMusicalName.Location = new Point(lTheaterName.Location.X + lTheaterName.Size.Width, lTheaterName.Location.Y);
            lMusicalName.Text = "bitte Musical auswählen";
            CreateSeatsGrid();
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
            if (useTimer1)
            {
                if (!slideTimer1.Enabled)
                    slideTimer1.Start();
            }
            else
            {
                if (isExpanded1)
                {
                    tcTheaters.Visible = false;
                    tcTheaters.Location = new Point((fullWidth1 * -1), tcTheaters.Location.Y);
                    btSlider1.Text = "SHOW";
                    isExpanded1 = false;
                }
                else
                {
                    tcTheaters.Visible = true;
                    tcTheaters.Location = new Point(0, tcTheaters.Location.Y);
                    btSlider1.Text = "HIDE";
                    isExpanded1 = true;
                    tcTheaters.BringToFront();
                    btSlider1.BringToFront();
                }
                btSlider1.Location = new Point(tcTheaters.Location.X + fullWidth1, btSlider1.Location.Y);
            }


        }
        private void btSlider2_Click(object sender, EventArgs e)
        {
            if (!slideTimer2.Enabled)
                slideTimer2.Start();
        }

        private void SlideTimer1_Tick(object sender, EventArgs e)
        {
            if (isExpanded1)
            {
                if (tcTheaters.Location.X <= (fullWidth1 * -1))
                {
                    tcTheaters.Visible = false;
                    slideTimer1.Stop();
                    btSlider1.Text = "SHOW";
                    isExpanded1 = false;
                }
                else
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
                    tcTheaters.Location = new Point(0, tcTheaters.Location.Y);
                    slideTimer1.Stop();
                    btSlider1.Text = "HIDE";
                    isExpanded1 = true;
                    tcTheaters.BringToFront();
                    btSlider1.BringToFront();

                }
            }
            btSlider1.Location = new Point(tcTheaters.Location.X + fullWidth1, btSlider1.Location.Y);
        }
        private void SlideTimer2_Tick(object sender, EventArgs e)
        {
            if (isExpanded2)
            {
                if (tcCustomers.Location.X >= this.ClientSize.Width)
                {
                    tcCustomers.Visible = false;
                    slideTimer2.Stop();
                    btSlider2.Text = "SHOW";
                    isExpanded2 = false;
                }
                else
                    tcCustomers.Location = new Point(tcCustomers.Location.X + step, tcCustomers.Location.Y);
            }
            else
            {
                tcCustomers.Visible = true;
                if (tcCustomers.Location.X > (this.ClientSize.Width - fullWidth2))
                {
                    tcCustomers.Location = new Point(tcCustomers.Location.X - step, tcCustomers.Location.Y);
                }
                else
                {
                    tcCustomers.Location = new Point(this.ClientSize.Width - fullWidth2, tcCustomers.Location.Y);
                    slideTimer2.Stop();
                    btSlider2.Text = "HIDE";
                    isExpanded2 = true;
                    tcCustomers.BringToFront();
                    btSlider2.BringToFront();
                }
            }
            btSlider2.Location = new Point(tcCustomers.Location.X - btSlider2.Width, btSlider2.Location.Y);
        }

        private void MainScreen_Resize(object sender, EventArgs e)
        {
            btSlider1.Location = new Point(tcTheaters.Location.X + fullWidth1, 0); // btSlider1.Location.Y
            btSlider2.Location = new Point(tcCustomers.Location.X - btSlider2.Width, 0); // btSlider2.Location.Y
        }

        private void dGVMusicals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dGVMusicals.Rows[e.RowIndex];
            int musicalId = Convert.ToInt32(row.Cells[0].Value);
            mainMusical = Musical.Get(musicalId);
            lMusicalName.Text = mainMusical.Title;
        }


        private void CreateSeatsGrid()
        {
            RemoveSeats();
            mainSeats = new Button[mainTheater.Rows, mainTheater.Seats];
            for (int r = 0; r < mainTheater.Rows; r++)
            {
                for (int c = 0; c < mainTheater.Seats; c++)
                {
                    Button btn = new Button();
                    btn.Text = $"{r},{c}";
                    btn.Margin = new Padding(0);
                    btn.Tag = (r, c);
                    // btn.Click += Btn_Click;

                    pSeats.Controls.Add(btn);
                    mainSeats[r, c] = btn;
                }
            }

            ResizeSeats();
        }

        private void ResizeSeats()
        {
            if (mainSeats == null) return;

            int panelWidth = pSeats.ClientSize.Width;
            int panelHeight = pSeats.ClientSize.Height;

            int buttonWidth = panelWidth / mainTheater.Seats;
            int buttonHeight = panelHeight / mainTheater.Rows;

            for (int r = 0; r < mainTheater.Rows; r++)
            {
                for (int c = 0; c < mainTheater.Seats; c++)
                {
                    Button btn = mainSeats[r, c];
                    btn.SetBounds(c * buttonWidth, r * buttonHeight, buttonWidth - 2, buttonHeight - 2);
                }
            }
        }

        private void RemoveSeats()
        {
            if (mainSeats == null) return;

            for (int r = 0; r < mainSeats.GetLength(0); r++)
            {
                for (int c = 0; c < mainSeats.GetLength(1); c++)
                {
                    Button btn = mainSeats[r, c];
                    if (btn != null)
                    {
                        btn.Parent?.Controls.Remove(btn);
                        btn.Dispose();
                    }
                }
            }
        }

        private void pSeats_SizeChanged(object sender, EventArgs e)
        {
            ResizeSeats();
        }
    }
}
