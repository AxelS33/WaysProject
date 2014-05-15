﻿using System;
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
    /// Logique d'interaction pour WOrientationUpdateQuestion.xaml
    /// </summary>
    public partial class WOrientationUpdateQuestion : Window
    {
        public WOrientationUpdateQuestion()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdateQuestion_Click(object sender, RoutedEventArgs e)
        {
            WOrientationQuestionMenu oFQuestionMenu = new WOrientationQuestionMenu();
            oFQuestionMenu.Show();
            this.Close();
        }

        private void BtnCancelUpdateQuestion_Click(object sender, RoutedEventArgs e)
        {
            WOrientationQuestionMenu oFQuestionUpdate = new WOrientationQuestionMenu();
            oFQuestionUpdate.Show();
            this.Close();
        }
    }
}
