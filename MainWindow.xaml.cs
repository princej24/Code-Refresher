using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Code_Refresher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Player> players = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            // Get user input for name and number
            string name = inputName.Text;
            if (int.TryParse(inputNumber.Text, out int number))
            {
                // Create a new player object
                Player newPlayer = new Player { Name = name, Number = number };
                players.Add(newPlayer);
                inputName.Clear();
                inputNumber.Clear();
                MessageBox.Show("Player added successfully.");
            }
            else
            {
                MessageBox.Show("Please enter a valid number// Name .");
            }
        }

        private void DisplayAllPlayers_Click(object sender, RoutedEventArgs e)
        {
            // Display all player names in a message box
            string playerNames = string.Join(", ", players.Select(p => p.Name));
            MessageBox.Show("All Players: " + playerNames);
        }

        private void DisplayOddNumberPlayers_Click(object sender, RoutedEventArgs e)
        {
            // Display players with odd numbers in a message box
            string oddPlayers = string.Join(", ", players.Where(p => p.Number % 2 != 0).Select(p => p.Name));
            MessageBox.Show("Players with Odd Numbers: " + oddPlayers);
        }

        private void DisplayPlayersByLetter_Click(object sender, RoutedEventArgs e)
        {
            // Display players whose names start with the specified letter (case-insensitive) in a message box
            string letter = inputLetter.Text.ToLower();
            string matchingPlayers = string.Join(", ", players.Where(p => p.Name.ToLower().StartsWith(letter)).Select(p => p.Name));
           

            MessageBox.Show($"Players whose names start with '{letter}': {matchingPlayers}");

        }
    }
}


