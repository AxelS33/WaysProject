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
using System.Windows.Shapes;

namespace Wayz
{
    /// <summary>
    /// Logique d'interaction pour WGameAdmin.xaml
    /// </summary>
    public partial class WGameAdmin : Window
    {
        public WGameAdmin()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Do you really want to print the score ?", "Print Score", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                //do something
            }
            else if (dialogResult == MessageBoxResult.No)
            {
                //do something else
            }
        }

        private void BtnQuestionTable_Click(object sender, RoutedEventArgs e)
        {
            WGameQuestionMenu oFQuestionMenu = new WGameQuestionMenu();
            oFQuestionMenu.Show();
            this.Close();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnOrganization_Click(object sender, RoutedEventArgs e)
        {
            WGameOrganization oFOrganization = new WGameOrganization();
            oFOrganization.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WMainMenuAdmin oFMainMenu = new WMainMenuAdmin();
            oFMainMenu.Show();
            this.Close();
        }

    }
}
