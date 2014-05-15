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
    /// Logique d'interaction pour WGameFinalResult.xaml
    /// </summary>
    public partial class WGameFinalResult : Window
    {
        public WGameFinalResult()
        {
            InitializeComponent();
        }

        private void BtnHelpUs_Click(object sender, RoutedEventArgs e)
        {
            WGameHelpUs oFHelpUs = new WGameHelpUs();
            oFHelpUs.Show();
            this.Close();
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFinalResult_Click(object sender, RoutedEventArgs e)
        {
            WGameFinalResult oFFinalResult = new WGameFinalResult();
            oFFinalResult.Show();
            this.Close();
        }
    }
}
