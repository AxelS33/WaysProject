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
    /// Logique d'interaction pour WGameQuestionnary.xaml
    /// </summary>
    public partial class WGameQuestionnary : Window
    {
        public WGameQuestionnary()
        {
            InitializeComponent();
        }

        private void BtnFinalResult_Click(object sender, RoutedEventArgs e)
        {
            WGameFinalResult oFFinalResult = new WGameFinalResult();
            oFFinalResult.Show();
            this.Close();
        }
    }
}
