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
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NovoCorrentista());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Correntistas c = await DataServiceCorrentista.Autorizar(new Correntistas
                {                   
                    Senha = txtSenha.Text,                   
                    CPF = txtCPF.Text
                });
                Console.WriteLine(c.Id);
                if(c.Id != 0){
                    string msg = $"Correntista logado com sucesso. Código gerado: {c.Id} ";

                    await DisplayAlert("Sucesso!", msg, "OK");

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
        }
    }
}