using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppNewBank.Model;
using AppNewBank.Service;

namespace AppNewBank.View.Correntista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NovoCorrentista : ContentPage
	{
		public NovoCorrentista ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {              
                Correntistas c = await DataServiceCorrentista.Cadastrar(new Correntistas
                {
                    Nome = txtNome.Text,
                    Senha = txtSenha.Text,
                    Data_Nasc = txtDataNasc.Date.ToString("yyyy-MM-dd"),
                    CPF = txtCPF.Text
                });

                string msg = $"Correntista inserido com sucesso. Código gerado: {c.Id} ";

                await DisplayAlert("Sucesso!", msg, "OK");

                await Navigation.PushAsync(new View.Correntista.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}