//Nathan Peereboom
//April 1, 2020
//Waterloo Problem J1: Dog Treats
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

namespace _312840DogTreats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int smallTreats;
        int mediumTreats;
        int largeTreats;
        int happinessScore;
        string dogMood;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFeed_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txtSmall.Text, out smallTreats);
            int.TryParse(txtMedium.Text, out mediumTreats);
            int.TryParse(txtLarge.Text, out largeTreats);
            happinessScore = smallTreats + (2 * mediumTreats) + (3 * largeTreats);
            if (happinessScore >= 10)
            {
                dogMood = "happy";
            }
            else
            {
                dogMood = "sad";
            }
            lblOutput.Content = dogMood;
        }
    }
}
