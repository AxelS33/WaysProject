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
    /// Logique d'interaction pour WGameUpdateQuestion.xaml
    /// </summary>
    public partial class WGameUpdateQuestion : Window
    {
        public WGameUpdateQuestion()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdateQuestion_Click(object sender, RoutedEventArgs e)
        {
            WGameQuestionMenu oFQuestionMenu = new WGameQuestionMenu();
            oFQuestionMenu.Show();
            this.Close();
        }

        private void BtnCancelUpdateQuestion_Click(object sender, RoutedEventArgs e)
        {
            WGameQuestionMenu oFQuestionUpdate = new WGameQuestionMenu();
            oFQuestionUpdate.Show();
            this.Close();
        }
    }
}
