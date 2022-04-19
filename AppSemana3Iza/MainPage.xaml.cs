using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSemana3Iza
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;

            await Navigation.PushAsync(new Page2(user, pass));
        }
    }
}
