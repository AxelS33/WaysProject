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

namespace Wayz
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class WLogin : Window
    {
        public WLogin()
        {
            InitializeComponent();
        }

        private void BtnLoginGuest_Click(object sender, RoutedEventArgs e)
        {
            WMainMenuUser oFMenuUser = new WMainMenuUser();
            oFMenuUser.Show();
            this.Close();
        }

        private void BtnLoginAdmin_Click(object sender, RoutedEventArgs e)
        {
            WMainMenuAdmin oFMenuAdmin = new WMainMenuAdmin();
            oFMenuAdmin.Show();
            this.Close();
        }

    }
}
