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
    /// Logique d'interaction pour WOrientationQuestionnary.xaml
    /// </summary>
    public partial class WOrientationQuestionnary : Window
    {
        public WOrientationQuestionnary()
        {
            InitializeComponent();
        }

        private void BtnFinalResult_Click(object sender, RoutedEventArgs e)
        {
            WOrientationFinalResult oFFinalResult = new WOrientationFinalResult();
            oFFinalResult.Show();
            this.Close();
        }
    }
}
