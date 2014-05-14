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
    /// Logique d'interaction pour WMainMenuAdmin.xaml
    /// </summary>
    public partial class WMainMenuAdmin : Window
    {
        public WMainMenuAdmin()
        {
            InitializeComponent();
        }

        private void BtnGame(object sender, RoutedEventArgs e)
        {
            WGameQuestionMenu oFQuestionMenu = new WGameQuestionMenu();
            oFQuestionMenu.Show();
            this.Close();
        }

        private void BtnOrientation(object sender, RoutedEventArgs e)
        {
            WGameQuestionMenu oFQuestionMenu = new WGameQuestionMenu();
            oFQuestionMenu.Show();
            this.Close();
        }
    }
}
