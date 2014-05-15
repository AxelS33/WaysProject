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
            msg.data = new Object[] {this.txtBoxUsername.Text, "", 1};
         
            //msg = waysgame.launch(msg);
            // ------------------------------------ test debut ------------------------------------
            Mapping.Questionnary questionnary = new Questionnary();
            Mapping.Question q = new Question();
            Mapping.Question q2 = new Question();
            Mapping.Answer ans1 = new Answer();
            Mapping.Answer ans2 = new Answer();
            Mapping.Answer ans3 = new Answer();
            Mapping.Answer ans4 = new Answer();
            ans1.setDescription("blablahiush");
            ans1.setScore(1);
            ans2.setDescription("gdqskgdkhgf");
            ans2.setScore(10);
            ans3.setDescription("azret");
            ans3.setScore(5);
            ans4.setDescription("blablahiush");
            ans4.setScore(1);
            q2.setDescription("Quelgglglgg ?");
            q.setDescription("Quel ze ?");
            q.listAnswer.Add(ans1);
            q.listAnswer.Add(ans2);
            q.listAnswer.Add(ans3);
            q2.listAnswer.Add(ans4);
            q.setOrder(1);
            q2.setOrder(2);
            List<Question> list = new List<Question>();
            list.Add(q);
            list.Add(q2);
            questionnary.setListQuestion(list);
            Player player = new Player();
            player = new Player();
            player.setPseudo("test");
            player.setScore(0);
            msg.data[0] = player;
            msg.data[1] = questionnary;
            msg.data[2] = 1;
            // ------------------------------------ test fin ------------------------------------
            //msg.data[2] = 1;
            WGameQuestionnary oFGameQuestionnary = new WGameQuestionnary(msg);/*msg);*/
            oFGameQuestionnary.Show();

            this.Close();
        }
    }
}
