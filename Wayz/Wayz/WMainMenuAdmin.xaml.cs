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

        private void BtnGame_Click(object sender, RoutedEventArgs e)
        {
            WGameAdmin oFGameAdmin = new WGameAdmin();
            oFGameAdmin.Show();
            this.Close();
        }

        private void BtnOrientation_Click(object sender, RoutedEventArgs e)
        {
            WOrientationAdmin oFOrientationAdmin = new WOrientationAdmin();
            oFOrientationAdmin.Show();
            this.Close();
        }
    }
}
