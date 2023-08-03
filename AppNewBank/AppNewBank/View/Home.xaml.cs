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
            btnVerExtrato.Source = ImageSource.FromResource("AppNewBank.View.assets.right.png");
            logoImg.Source = ImageSource.FromResource("AppNewBank.View.assets.img.nubank-logo.png");

            btnPix.Source = ImageSource.FromResource("AppNewBank.View.assets.icon-actions.pix.png");
            btnPagar.Source = ImageSource.FromResource("AppNewBank.View.assets.icon-actions.pagar.png");
            btnInvestir.Source = ImageSource.FromResource("AppNewBank.View.assets.icon-actions.investir.png");
            btnPoupar.Source = ImageSource.FromResource("AppNewBank.View.assets.icon-actions.poupar.png");
            btnDoar.Source = ImageSource.FromResource("AppNewBank.View.assets.icon-actions.doar.png");
        }

        private void showIcon_Clicked(object sender, EventArgs e)
        {

        }
    }
}