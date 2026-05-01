using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BnA
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.Show();

            this.Hide();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            LoadChart();
        }

        private DataTable GetMovieStatistics()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=BnA.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT MovieName, BookingCount FROM MovieStatistics"; 
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void LoadChart()
        {
            chartMovies.Series.Clear();
            chartMovies.ChartAreas.Clear();
            chartMovies.ChartAreas.Add("MainArea");

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Bookings",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };

            chartMovies.Series.Add(series);

            DataTable stats = GetMovieStatistics();
            int colorIndex = 0;

            
            List<Color> colors = new List<Color>
            {
                Color.Red,
                Color.Green,
                Color.Blue,
                Color.Yellow,
                Color.Orange,
                Color.Purple,
                Color.Cyan,
                Color.Magenta,
                Color.Brown,
                Color.Gray
            };

            foreach (DataRow row in stats.Rows)
            {
                string movieName = row["MovieName"].ToString();
                int bookingCount = Convert.ToInt32(row["BookingCount"]);

                
                var point = series.Points.AddXY(movieName, bookingCount);

                
                series.Points[colorIndex].Color = colors[colorIndex % colors.Count];
                colorIndex++;
            }

            chartMovies.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void chartMovies_Click(object sender, EventArgs e)
        {

        }
    }
}
