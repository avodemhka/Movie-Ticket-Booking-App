using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BnA
{
    public partial class Movie : Form
    {
        public string FilmName { get; set; } 
        public string FilmDescription { get; set; }
        public Image FilmImage { get; set; } 

        public Movie()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.Show();

            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Movie_Load(object sender, EventArgs e)
        {
            lblFilmName.Text = FilmName;
            lblFilmDescription.Text = FilmDescription;
            pictureBox1.Image = FilmImage;
        }

        private void lblFilmName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seats seats = new Seats();
            seats.Show();
        }
    }
}
