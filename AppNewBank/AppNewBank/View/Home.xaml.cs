using AppNewBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNewBank.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            labelWelcome.Text = "Olá, " + Convert.ToString(Application.Current.Properties["nome_correntista"]) + "!";
            NavigationPage.SetHasNavigationBar(this, false);

            showIcon.Source = ImageSource.FromResource("AppNewBank.View.assets.show-solid.png");
            logoImg.Source = ImageSource.FromResource("AppNewBank.View.assets.img.nubank-logo.png");
        }

        private void showIcon_Clicked(object sender, EventArgs e)
        {

        }
    }
}