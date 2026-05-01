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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 logForm = new Form1();
            logForm.Show();

            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void film1_Click(object sender, EventArgs e)
        {
            OpenBiletForm("Kingdom of the Planet of the Apes", "Director Wes Ball breathes new life into the global, epic franchise set several generations in the future following Caesar’s reign, in which apes are the dominant species living harmoniously and humans have been reduced to living in the shadows.", BnA.Properties.Resources.MaymunlarCehennemi);
        }

        private void film2_Click(object sender, EventArgs e)
        {
            OpenBiletForm("Dune", "A mythic and emotionally charged hero's journey, \"Dune\" tells the story of Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, who must travel to the most dangerous planet in the universe to ensure the future of his family and his people.", BnA.Properties.Resources.Dune);
        }

        private void film3_Click(object sender, EventArgs e)
        {
            OpenBiletForm("Uncharted", "Uncharted is an action-adventure video game series and media franchise published by Sony Interactive Entertainment and developed by Naughty Dog. Created by Amy Hennig, the Uncharted franchise follows a group of treasure hunters who travel across the world to uncover various historical mysteries.", BnA.Properties.Resources.Uncharted);
        }

        private void film4_Click(object sender, EventArgs e)
        {
            OpenBiletForm("The Grey Man", "When a shadowy CIA operative uncovers damning agency secrets, he becomes the target of a rogue asset determined to eliminate him by any means necessary. Ryan Gosling and Chris Evans star with Ana de Armas and Regé-Jean Page in this global action thriller from the Russo brothers.", BnA.Properties.Resources.TheGreyMan);
        }

        private void film5_Click(object sender, EventArgs e)
        {
            OpenBiletForm("Ice Age", "Manny the mammoth, Sid the loquacious sloth, and Diego the sabre-toothed tiger go on a comical quest to return a human baby back to his father, across a world on the brink of an ice age. On Earth 20,000 years ago, everything was covered in ice.", BnA.Properties.Resources.IceAge);
        }

        private void film6_Click(object sender, EventArgs e)
        {
            OpenBiletForm("Oppenheimer", "Oppenheimer is a 2023 epic biographical drama film written, produced, and directed by Christopher Nolan. It follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.", BnA.Properties.Resources.Oppenheimer);
        }

        private void film7_Click(object sender, EventArgs e)
        {
            OpenBiletForm("Home Alone", "Home Alone, Christmas family comedy film released in 1990 about the adventures of Kevin McCallister, an eight-year-old boy, played by Macaulay Culkin, who has to fend for himself and thwart the attempts of a pair of bungling burglars trying to break into his family’s house after he is inadvertently left behind when his family departs for a holiday trip to France.", BnA.Properties.Resources.HomeAlone);
        }

        private void film8_Click(object sender, EventArgs e)
        {
            OpenBiletForm("John Wick", "John Wick (Keanu Reeves) uncovers a path to defeating The High Table. But before he can earn his freedom, Wick must face off against a new enemy with powerful alliances across the globe and forces that turn old friends into foes.", BnA.Properties.Resources.JohnWick);
        }

        private void film9_Click(object sender, EventArgs e)
        {
            OpenBiletForm("The Greatest Showman", "Celebrates the birth of show business and tells of a visionary who rose from nothing to create a spectacle that became a worldwide sensation. In the late 19th century, P. T. Barnum and his troupe perform a show at the circus The Greatest Show.", BnA.Properties.Resources.GreatestShowman);
        }

        private void film10_Click(object sender, EventArgs e)
        {
            OpenBiletForm("Avatar", "Set more than a decade after the events of the first film, \"Avatar: The Way of Water\" begins to tell the story of the Sully family (Jake, Neytiri, and their kids), the trouble that follows them, the lengths they go to keep each other safe, the battles they fight to stay alive, and the tragedies they endure", BnA.Properties.Resources.Avatar);
        }

        private void OpenBiletForm(string v1, string v2, object avatar)
        {
            throw new NotImplementedException();
        }

        private void OpenBiletForm(string filmName, string filmDescription, Image filmImage)
        {
            Movie biletForm = new Movie
            {
                FilmName = filmName,
                FilmDescription = filmDescription,
                FilmImage = filmImage
            };
            biletForm.ShowDialog();
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statsForm = new StatisticsForm();
            statsForm.Show();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            Seats seats = new Seats();
            seats.Show();
        }
    }
    
}
