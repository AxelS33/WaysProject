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
    /// Logique d'interaction pour WOrganizeQuestionnary.xaml
    /// </summary>
    public partial class WOrganizeQuestionnary : Window
    {
        public WOrganizeQuestionnary()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            WGameOrganization oFGameOrganization = new WGameOrganization();
            oFGameOrganization.Show();
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            WGameOrganization oFGameOrganization = new WGameOrganization();
            oFGameOrganization.Show();
            this.Close();
        }
    }
}
