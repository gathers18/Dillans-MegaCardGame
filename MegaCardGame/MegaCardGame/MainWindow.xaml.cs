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

namespace MegaCardGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        string selectedClass;

        public MainWindow()
        {
            InitializeComponent();
            PlayerCharacter player = new PlayerCharacter();
            this.DataContext = player;
        }

        private void SelectButton_Click(object sender, GameController, RoutedEventArgs e)
        {
            AttackScreen page = new AttackScreen(selectedClass);
            Battle battle = new Battle();
            NavigationService.Navigate(battle);
        }

        private void ClassListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedClass = ((ListBoxItem)ClassListBox.SelectedValue).Content.ToString();
            BitmapImage logo = new BitmapImage();

            switch (selectedClass)
            {
                case "Warrior":
                    DetailsLabel.Content = "Berserk \n" +
                                            "1 in 3 Success Rate \n" +
                                            "+ 3x Damage \n" +
                                            "- no attack made";
                    logo.UriSource = new Uri("pack://application:,,,/AssemblyName;component/Resources/Warrior.jpg");
                    break;
                default:
                    break;

                case "Mage":
                    DetailsLabel.Content = "Fireball \n" +
                                            "1 in 2 Success Rate \n" +
                                            "+ 4x Damage \n" +
                                            "- 1x Damage to self";
                    logo.UriSource = new Uri("pack://application:,,,/AssemblyName;component/Resources/Mage.jpg");
                    break;

                case "Thief":
                    DetailsLabel.Content = "Backstab \n" +
                                            "1 in 3 Success Rate \n" +
                                            "+ 2x Damage \n" +
                                            "- 0.5 Damage";
                    logo.UriSource = new Uri("pack://application:,,,/AssemblyName;component/Resources/Thief.jpg");
                    break;
            }
        }
    }
}
