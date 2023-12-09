﻿using BabkinsDashBoard.Views;
using Models;
using Models.DataContext;
using Models.Repositories.RepositoryImpl;
using Models.Services.Implementation;
using Models.Services.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using Models.DbHelp;
using Models.Services;

namespace BabkinsDashBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IAuthoriseService _authoriseService;
        public MainWindow()
        {
            InitializeComponent();
            _authoriseService = App.AuthoriseService;
            DbInitializer.InitDatabase();
        }

        private void AuthoriseBtt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_authoriseService.TryAuthorizeUser(LoginTB.Text, PasswordTB.Text) != null)
                {
                    mainFrame.Navigate(new StartPage());
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
