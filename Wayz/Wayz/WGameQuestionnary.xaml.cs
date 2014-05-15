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
using Mapping;

namespace Wayz
{
    /// <summary>
    /// Logique d'interaction pour WGameQuestionnary.xaml
    /// </summary>
    public partial class WGameQuestionnary : Window
    {
        private client.CUT.WaysGame waysGame;
        private RadioButton button;
        private Questionnary questionnary;
        private Question curQuestion;
        private Player player;
        private int scoretmp;

        private Dictionary<RadioButton, int> answerMap;

        

        //private TextBlock QuestionGame;
        public WGameQuestionnary()
        {
            InitializeComponent();
        }

        public WGameQuestionnary(StgMsg.StgMsg msg)
        {
            //this.questionnary = (Questionnary)msg.data[1];
            //this.player = (Player)msg.data[0];

            // ------------------------------------ test debut ------------------------------------
            Mapping.Questionnary questionnary = new Questionnary();
            Mapping.Question q = new Question();
            Mapping.Question q2 = new Question();
            Mapping.Answer ans1 = new Answer();
            Mapping.Answer ans2 = new Answer();
            Mapping.Answer ans3 = new Answer();
            ans1.setDescription("blablahiush");
            ans1.setScore(1);
            ans2.setDescription("gdqskgdkhgf");
            ans2.setScore(10);
            ans3.setDescription("azret");
            ans3.setScore(5);
            q2.setDescription("Quelgglglgg ?");
            q.setDescription("Quel ze ?");
            q.listAnswer.Add(ans1);
            q.listAnswer.Add(ans2);
            q.listAnswer.Add(ans3);
            q.setOrder(1);
            List<Question> list = new List<Question>();
            list.Add(q);
            questionnary.setListQuestion(list);
            this.player = new Player();
            this.player.setPseudo("test");
            this.player.setScore(0);
            this.questionnary = questionnary;
            // ------------------------------------ test fin ------------------------------------


            this.scoretmp = 0;
            //this.QuestionGame = new TextBlock();
            InitializeComponent();
            
            //Question question;

            this.setQuestion(1);
            this.setAnswer(this.curQuestion);
            
        }

        private void BtnFinalResult_Click(object sender, RoutedEventArgs e)
        {
            WGameFinalResult oFFinalResult = new WGameFinalResult();
            oFFinalResult.Show();
            this.Close();
        }

        private void setQuestion(int order)
        {
            foreach (Question q in this.questionnary.getListQuestion())
            {
                if (q.getOrder() == order)
                {
                    this.curQuestion = q;
                    this.QuestionGame.Text = this.curQuestion.getDescription();
                }
            }
        }

        private void setAnswer(Question question)
        {
            int topMargin = 246;
            this.answerMap = new Dictionary<RadioButton, int>();

            foreach (Answer ans in question.getListAnswer())
            {
                RadioButton button = new RadioButton();
                button.Content = ans.getDescription();
                button.ToolTip = ans.getWeight();

                answerMap.Add(button, ans.getWeight());
                string testscore = ans.getWeight().ToString();
                
                button.HorizontalAlignment=HorizontalAlignment.Center;
                button.VerticalAlignment=VerticalAlignment.Top;

                Thickness margin = button.Margin;
                margin.Left = 0;
                margin.Top = topMargin;
                margin.Right = 0;
                margin.Bottom = 0;
                button.Margin = margin;

                button.Click += new RoutedEventHandler(this.buttonClick);

                this.gridQuestionnary.Children.Add(button);
                topMargin += 30;
            }
        }

        private void buttonClick(Object sender, EventArgs e)
        {
            RadioButton test = (RadioButton)sender;
            this.scoretmp = this.answerMap[test];
            //MessageBox.Show(weight.ToString());
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            this.addScorePlayer(this.scoretmp);
            this.scoretmp = 0;
            
            //waysGame.addScorePlayer();
            this.gridQuestionnary.Children.Clear();
            InitializeComponent();
            this.setQuestion(this.curQuestion.getOrder() + 1);
            this.setAnswer(this.curQuestion);
        }

        private void addScorePlayer(int score)
        {
            this.player.setScore(this.player.getScore() + score);
        }
    }
}
