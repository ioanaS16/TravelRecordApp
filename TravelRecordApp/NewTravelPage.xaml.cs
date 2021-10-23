using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //INSERARE IN DB

            Post post = new Post()
            {
                Experience = experienceEntry.Text //Id ul se pune automat, cu parantezele am setat proprietatea pt post
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();
            int rows = conn.Insert(post); //metoda returneaza numarul de randuri introduse
            conn.Close();

            if(rows > 0)
            {
                DisplayAlert("Succes", "Experience succesfully inserted", "Ok");
            }
            else
            {
                DisplayAlert("Failure", "Experience failed to be inserted", "Ok");
            }
        }
    }
}