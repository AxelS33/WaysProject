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
    /// Logique d'interaction pour WGameKnowledge.xaml
    /// </summary>
    public partial class WGameKnowledge : Window
    {
        public WGameKnowledge()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            WMainMenuUser oFMainMenu = new WMainMenuUser();
            oFMainMenu.Show();
            this.Close();
        }
    }
}
