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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProductShop.Components;

namespace ProductShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        public AuthorPage()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (PassBx.Password == "0000")
            {
                App.isAdmin = true;
                MessageBox.Show("Вы вошли как администратор!");
                Navigation.NextPage(new PageComponent(new ProductListPage()));
            }
            else if (PassBx.Password != "" && PassBx.Password != "0000") MessageBox.Show("Неверно!");
            else
            {
                MessageBox.Show("Вы вошли как пользователь!");
                Navigation.NextPage(new PageComponent(new ProductListPage()));
            }

        }
    }
}
