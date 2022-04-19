using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSemana3Iza
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string user, string pass)
        {
            InitializeComponent();

            lblUser.Text = user;
            lblPass.Text = pass;
        }

       
    }
}