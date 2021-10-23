using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void loginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text); //returneaza true daca elementul e gol
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);
            
            if( isEmailEmpty || isPasswordEmpty ) //doar daca una sau doua sunt adevarate
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
