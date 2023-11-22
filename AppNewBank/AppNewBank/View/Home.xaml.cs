using AppNewBank.Model;
using AppNewBank.View.Correntista;
using AppNewBank.View.Funcoes;
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
            txtSaldo.Text = "R$ " + Convert.ToString(Application.Current.Properties["saldo_correntista"]);
            NavigationPage.SetHasNavigationBar(this, false);

            showIcon.Source = ImageSource.FromResource("AppNewBank.View.assets.show-solid.png");
            btnVerExtrato.Source = ImageSource.FromResource("AppNewBank.View.assets.right.png");
            logoImg.Source = ImageSource.FromResource("AppNewBank.View.assets.img.nubank-logo.png");

            btnPix.Source = ImageSource.FromResource("AppNewBank.View.assets.pix.png");
            btnPagar.Source = ImageSource.FromResource("AppNewBank.View.assets.pagar.png");
            btnInvestir.Source = ImageSource.FromResource("AppNewBank.View.assets.investir.png");
            
            btnDoar.Source = ImageSource.FromResource("AppNewBank.View.assets.doar.png");
        }

        private void showIcon_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPix_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AreaPix());
        }

        private void btnPagar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EnviarPix());
        }

        private void btnInvestir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReceberPix());
        }

        private void btnDoar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Doar());
        }
    }
}