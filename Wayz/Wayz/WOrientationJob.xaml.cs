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
    /// Logique d'interaction pour WOrientationJob.xaml
    /// </summary>
    public partial class WOrientationJob : Window
    {
        public WOrientationJob()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            WMainMenuUser oFMainMenu = new WMainMenuUser();
            oFMainMenu.Show();
            this.Close();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Do you want to send your mail ?", "Mail in progress", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                //do something
            }
            else if (dialogResult == MessageBoxResult.No)
            {
                //do something else
            }
        }


    }
}
