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
    /// Interaction logic for AttackScreen.xaml
    /// </summary>
    public partial class AttackScreen : Page
    {
        public AttackScreen(string pSelectedClass)
        {
            InitializeComponent();
        }

        private void Specialbut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Normalbut_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EnemyList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnemyList.ItemsSource = LoadListBoxData();

            public ArrayList LoadListBoxData()
            {
                ArrayList itemsList = new ArrayList();
                itemsList.Add("Health Points: ");
                itemsList.Add();
                itemsList.Add("Attack Damage: ");
                itemsList.Add();
                return itemsList;
            }
        }

        private void CharList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CharList.ItemsSource = LoadListBoxData();

            public ArrayList LoadListBoxData()
            {
                ArrayList itemsList = new ArrayList();
                itemsList.Add("Health Points: ");
                itemsList.Add();
                itemsList.Add("Standard Attack Damage: ");
                itemsList.Add();
                itemsList.Add("Attack Damage: ");
                itemsList.Add();
                return itemsList;
            }
        }

        private void Yimage_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void Eimage_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
