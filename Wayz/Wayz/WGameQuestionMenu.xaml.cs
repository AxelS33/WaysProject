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
    /// Logique d'interaction pour WGameQuestionMenu.xaml
    /// </summary>
    public partial class WGameQuestionMenu : Window
    {
        public WGameQuestionMenu()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            WGameUpdateQuestion oFGameUpdate = new WGameUpdateQuestion();
            oFGameUpdate.Show();
            this.Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            WGameAddQuestion oFGameAdd = new WGameAddQuestion();
            oFGameAdd.Show();
            this.Close();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                //do something
            }
            else if (dialogResult == MessageBoxResult.No)
            {
                //do something else
            }
        }

        private void BtnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            WMainMenuAdmin oFMainMenu = new WMainMenuAdmin();
            oFMainMenu.Show();
            this.Close();
        }


    }
}
