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
    /// Logique d'interaction pour WOrientationFinalResult.xaml
    /// </summary>
    public partial class WOrientationFinalResult : Window
    {
        public WOrientationFinalResult()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            WOrientationJob oFOrientation = new WOrientationJob();
            oFOrientation.Show();
            this.Close();
        }
    }
}
