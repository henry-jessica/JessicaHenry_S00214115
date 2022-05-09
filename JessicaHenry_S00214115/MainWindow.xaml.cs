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

namespace JessicaHenry_S00214115
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> allGames; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            GameData db = new GameData(); 

            var query = from g in db.Games
                        orderby g.Name
                        select g;

            allGames = query.ToList();

            lbxGames.ItemsSource = allGames;
        }

        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determinate what was selected 
            Game selected = lbxGames.SelectedItem as Game;
            //check no null
            if (selected != null)
            {
                //update display 

                tbxGameDetails.Text = selected.DisplayDetails();
                ImgGame.Source = new BitmapImage(new Uri(selected.Game_Image));
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            string platform = radio.Content.ToString();

            switch (platform)
            {
                case "PS":
                    lbxGames.ItemsSource = allGames.Where(g=> g.Platform.Contains("PS"));
                    break;
                case "Switch":
                    lbxGames.ItemsSource = allGames.Where(g => g.Platform.Contains("Switch"));
                    break;
                case "Xbox":
                    lbxGames.ItemsSource = allGames.Where(g => g.Platform.Contains("Xbox"));
                    break;
                default:
                    lbxGames.ItemsSource = allGames; 
                    break;


            }
        }
    }
}
