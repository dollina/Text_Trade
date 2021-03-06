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
using Text_Trade.Forms;

namespace Text_Trade
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            Create_Account createaccount = new Create_Account();
            createaccount.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Trader login = new Trader();
            TraderList userlist = new TraderList();
            List<Trader> searchResult = userlist.SearchForUser(usernameTextBox.Text);

            if (searchResult.Count == 0)
            {
                Invalid_Login badLogin = new Invalid_Login();
                badLogin.Show();
            }
            else
            {
                for (int i = 0; i < searchResult.Count; i++)
                {
                    if (searchResult[i].Password == passwordBox.Password)
                    {
                        login = searchResult[i];

                        if (login.isModerator())
                        {
                            Moderator mod = new Moderator(login.Username, login.Password, login.FirstName, login.LastName, login._Email.ToString(), login.Trader_id, login.isModerator());
                            Moderator_Home modhome = new Moderator_Home(mod);
                            modhome.Show();
                            this.Close();
                        }
                        else
                        {
                            TraderHome tradehome = new TraderHome(login);
                            tradehome.Show();
                            this.Close();
                        }

                        break;
                    }

                }

            }
        }
    }
}