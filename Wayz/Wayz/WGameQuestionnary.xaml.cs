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
        private RadioButton button;
        private Questionnary questionnary;
        private Question curQuestion;
        private GroupBox radioBox;
        //private TextBlock QuestionGame;
        public WGameQuestionnary()
        {
            InitializeComponent();
        }

        public WGameQuestionnary(Object questionnary)
        {
            this.questionnary = (Questionnary)questionnary;
            this.radioBox = new GroupBox();
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
           // Content="RadioButton" HorizontalAlignment="Center" Margin="0,246,0,0" VerticalAlignment="Top"
            int topMargin = 246;
            
            
            
                
            foreach (Answer ans in question.getListAnswer())
            {
                RadioButton button = new RadioButton();
                button.Content = ans.getDescription();
                
                button.HorizontalAlignment=HorizontalAlignment.Center;
                button.VerticalAlignment=VerticalAlignment.Top;

                Thickness margin = button.Margin;
                margin.Left = 0;
                margin.Top = topMargin;
                margin.Right = 0;
                margin.Bottom = 0;
                button.Margin = margin;

                Size size = button.RenderSize;
                size.Height = 30;
                size.Width = 70;
                button.RenderSize = size;

                //this.radioBox.

                button.Visibility = Visibility.Visible;
                
                //button.IsEnabled = true;
                //button.IsVisible = true;
                topMargin += 30;
            }
        }
    }
}
