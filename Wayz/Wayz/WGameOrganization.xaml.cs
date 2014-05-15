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
    /// Logique d'interaction pour WGameOrganization.xaml
    /// </summary>
    public partial class WGameOrganization : Window
    {
        public WGameOrganization()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            WOrganizeQuestionnary oFOrganize = new WOrganizeQuestionnary();
            oFOrganize.Show();
            this.Close();
        }

        private void BtnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            WMainMenuAdmin oFMainMenu = new WMainMenuAdmin();
            oFMainMenu.Show();
            this.Close();
        }
    }
}
