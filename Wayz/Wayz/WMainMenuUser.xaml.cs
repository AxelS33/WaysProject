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
using client.CUT;
using Mapping;

namespace Wayz
{
    /// <summary>
    /// Logique d'interaction pour Wayz___MainMenu.xaml
    /// </summary>
    public partial class WMainMenuUser : Window
    {
        private StgMsg.StgMsg msg;
        private WaysGame waysgame;

        public WMainMenuUser()
        {
            InitializeComponent();
        }

        private void BtnOrientation_Click(object sender, RoutedEventArgs e)
        {
            WOrientationQuestionnary oFOrientationQuestionnary = new WOrientationQuestionnary();
            oFOrientationQuestionnary.Show();
            this.Close();
        }

        private void BtnGame_Click(object sender, RoutedEventArgs e)
        {
            waysgame = new WaysGame();
            msg = new StgMsg.StgMsg();
            msg.data = new Object[] {this.txtBoxUsername.Text};
         
            //msg = waysgame.launch(msg);
            
            WGameQuestionnary oFGameQuestionnary = new WGameQuestionnary(msg);//msg.data[1]);
            oFGameQuestionnary.Show();

            this.Close();
        }
    }
}
