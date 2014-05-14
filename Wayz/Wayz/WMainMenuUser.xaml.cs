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
    /// Logique d'interaction pour Wayz___MainMenu.xaml
    /// </summary>
    public partial class WMainMenuUser : Window
    {
        public WMainMenuUser()
        {
            InitializeComponent();
        }

        private void BtnOrientation(object sender, RoutedEventArgs e)
        {
            WOrientationQuestionnary oFOrientationQuestionnary = new WOrientationQuestionnary();
            oFOrientationQuestionnary.Show();
            this.Close();
        }

        private void BtnGame(object sender, RoutedEventArgs e)
        {
            WGameQuestionnary oFGameQuestionnary = new WGameQuestionnary();
            oFGameQuestionnary.Show();
            this.Close();
        }
    }
}
