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
        private StgMsg.StgMsg msg;

        private Dictionary<RadioButton, int> answerMap;

        

        //private TextBlock QuestionGame;
        public WGameQuestionnary()
        {
            InitializeComponent();
        }

        public WGameQuestionnary(StgMsg.StgMsg msg)
        {
            this.msg = msg;
            this.questionnary = (Questionnary)msg.data[1];
            this.player = (Player)msg.data[0];

            this.scoretmp = 0;
            //this.BtnFinalResult.Visibility = Visibility.Hidden;
            //this.QuestionGame = new TextBlock();
            InitializeComponent();
            
            //Question question;

            this.setQuestion((int)msg.data[2]);
            this.setAnswer(this.curQuestion);

            if (curQuestion.getOrder() == 1)
            {
                this.BtnPrevious.Visibility = Visibility.Hidden;
            }
            else if (!this.nextQuestion(curQuestion.getOrder()))
            {
                this.BtnNext.Visibility = Visibility.Hidden;
                //this.BtnFinalResult.Visibility = Visibility.Visible;
            }
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

            if (question.getListAnswer() != null)
            {
                foreach (Answer ans in question.getListAnswer())
                {
                    RadioButton button = new RadioButton();
                    button.Content = ans.getDescription();
                    button.ToolTip = ans.getWeight();

                    answerMap.Add(button, ans.getWeight());
                    string testscore = ans.getWeight().ToString();

                    button.HorizontalAlignment = HorizontalAlignment.Center;
                    button.VerticalAlignment = VerticalAlignment.Top;

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
            //this.scoretmp = 0;
            
            //waysGame.addScorePlayer();
            //this.gridQuestionnary.Children.Clear();
            //InitializeComponent();
            //this.setQuestion();
            //this.setAnswer(this.curQuestion);
            this.msg.data[2] = this.curQuestion.getOrder() + 1;

            Wayz.WGameQuestionnary next = new WGameQuestionnary(this.msg);
            next.Show();
        }

        private void addScorePlayer(int score)
        {
            this.player.setScore(this.player.getScore() + score);
        }

        public bool nextQuestion(int curOrder)
        {
            foreach(Question q in this.questionnary.getListQuestion()){
                if (q.getOrder() == curOrder + 1){
                    return true;
                }
            }
            return false;
        }
    }
}
