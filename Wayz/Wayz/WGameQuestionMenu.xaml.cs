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
using System.Windows.Forms;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("My message here #pro #English");
        }
    }
}
