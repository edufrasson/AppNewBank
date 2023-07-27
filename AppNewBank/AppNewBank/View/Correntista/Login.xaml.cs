using AppNewBank.Model;
using AppNewBank.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNewBank.View.Correntista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            imgLogo.Source = ImageSource.FromResource("AppNewBank.View.assets.img.nubank-logo.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NovoCorrentista());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            carregando.IsRunning = true;
            try
            {
                Console.WriteLine(txtCPF.Text);
                Correntistas c = await DataServiceCorrentista.Autorizar(new Correntistas
                {                   
                    Senha = txtSenha.Text,                   
                    CPF = txtCPF.Text
                });
                
                if(c.Id != 0){
                    string msg = $"Correntista logado com sucesso. Código gerado: {c.Id} ";

                    await DisplayAlert("Sucesso!", msg, "OK");
                    Application.Current.Properties.Add("id_correntista", c.Id);
                    Application.Current.Properties.Add("nome_correntista", c.Nome);
                    await Navigation.PushAsync(new View.Home());
                }
                else
                {
                    string msg = $"Correntista não encontrado, tente logar novamente! ";

                    await DisplayAlert("Erro!", msg, "OK");

                    await Navigation.PushAsync(new View.Correntista.Login());
                }
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally{
                carregando.IsRunning = false;
            }
        }
    }
}