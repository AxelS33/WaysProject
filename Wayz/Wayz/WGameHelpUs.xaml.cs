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
    /// Logique d'interaction pour WGameHelpUs.xaml
    /// </summary>
    public partial class WGameHelpUs : Window
    {
        public WGameHelpUs()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            WGameKnowledge oFKnowledge = new WGameKnowledge();
            oFKnowledge.Show();
            this.Close();
        }
    }
}
