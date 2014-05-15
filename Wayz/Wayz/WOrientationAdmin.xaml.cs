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
    /// Logique d'interaction pour WOrientationAdmin.xaml
    /// </summary>
    public partial class WOrientationAdmin : Window
    {
        public WOrientationAdmin()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnQuestionTable_Click(object sender, RoutedEventArgs e)
        {
            WOrientationQuestionMenu oFOrientation = new WOrientationQuestionMenu();
            oFOrientation.Show();
            this.Close();
        }

        private void BtnGradingScale_Click(object sender, RoutedEventArgs e)
        {
            WGradingScale oFGradingScale = new WGradingScale();
            oFGradingScale.Show();
            this.Close();
        }

        private void BtnMail_Click(object sender, RoutedEventArgs e)
        {
            WOrientationEmailAccount oFEmail = new WOrientationEmailAccount();
            oFEmail.Show();
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
