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
    public partial class Seats : Form
    {
        public Seats()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seats_Load(object sender, EventArgs e)
        {
            GenerateSeats();
        }

        private void GenerateSeats()
        {
            panelSeats.Controls.Clear();
            int totalSeats = 24; // Общее количество мест
            int rows = 4; // Количество рядов
            int cols = totalSeats / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int seatNumber = i * cols + j + 1;

                    Button seatButton = new Button
                    {
                        Text = seatNumber.ToString(),
                        Width = 50,
                        Height = 50,
                        BackColor = Color.Green,
                        Margin = new Padding(5)
                    };

                    seatButton.Click += SeatButton_Click;
                    panelSeats.Controls.Add(seatButton);
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.BackColor == Color.Red)
            {
                MessageBox.Show("This seat is already booked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (clickedButton.BackColor == Color.Green)
            {
                clickedButton.BackColor = Color.Yellow; 
                lstSelectedTickets.Items.Add($"Seat {clickedButton.Text}");
            }
            else if (clickedButton.BackColor == Color.Yellow)
            {
                clickedButton.BackColor = Color.Green; 
                lstSelectedTickets.Items.Remove($"Seat {clickedButton.Text}");
            }

            UpdateSummary();
        }
      
        private void UpdateSummary()
        {
            if (cmbFilm.SelectedItem == null) return;

            var selectedTime = groupBoxTime.Controls.OfType<RadioButton>()
                                 .FirstOrDefault(rb => rb.Checked)?.Text;

            if (selectedTime == null) return;

            int ticketPrice = 150;
            int totalTickets = lstSelectedTickets.Items.Count;
            int totalPrice = totalTickets * ticketPrice;

            txtSummary.Text = $"Movie: {cmbFilm.SelectedItem}\r\n" +
                              $"Time: {selectedTime}\r\n" +
                              $"Total Price: {totalPrice}";
        }

        private void UpdateMovieStatistics(string movieName, int ticketsBooked)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=BnA.db;Version=3;"))
            {
                conn.Open();
                string query = @"
            INSERT INTO MovieStatistics (MovieName, BookingCount)
            VALUES (@MovieName, @TicketsBooked)
            ON CONFLICT(MovieName)
            DO UPDATE SET BookingCount = BookingCount + @TicketsBooked";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MovieName", movieName);
                    cmd.Parameters.AddWithValue("@TicketsBooked", ticketsBooked);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /*private void SaveSeatsToDatabase(string movieName, string time, int ticketsBooked)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=BnA.db;Version=3;"))
            {
                conn.Open();

 
                foreach (var seat in lstSelectedTickets.Items)
                {
                    string query = @"
                INSERT INTO Seats (Movie, Time, SeatNumber, IsOccupied)
                VALUES (@Movie, @Time, @SeatNumber, 1)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Movie", movieName);
                        cmd.Parameters.AddWithValue("@Time", time);
                        cmd.Parameters.AddWithValue("@SeatNumber", seat.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }*/



        private void btnComplete_Click(object sender, EventArgs e)
        {
            string selectedMovie = cmbFilm.SelectedItem?.ToString();
            string selectedTime = groupBoxTime.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text;


            if (cmbFilm.SelectedItem == null)
            {
                MessageBox.Show("Please select a movie.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedTime == null)
            {
                MessageBox.Show("Please select a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstSelectedTickets.Items.Count == 0)
            {
                MessageBox.Show("Please select at least one seat.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ticketsBooked = lstSelectedTickets.Items.Count;


           // SaveSeatsToDatabase(selectedMovie, selectedTime, ticketsBooked);


            string message = $"You have successfully booked tickets!\n\n" +
                    $"Movie: {cmbFilm.SelectedItem}\n" +
                    $"Time: {selectedTime}\n" +
                    $"Seats: {string.Join(", ", lstSelectedTickets.Items.Cast<string>())}\n" +
                    $"Thank you for your reservation.";

  
            MessageBox.Show(message, "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
          
            UpdateMovieStatistics(selectedMovie, ticketsBooked);
            lstSelectedTickets.Items.Clear();
            txtSummary.Clear();
            GenerateSeats();


        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateSeats();
        }

        private void groupBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            GenerateSeats();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.Show();

            this.Hide();
        }
    }
}
