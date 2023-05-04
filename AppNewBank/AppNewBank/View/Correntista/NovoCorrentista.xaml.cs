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
	public partial class NovoCorrentista : ContentPage
	{
		public NovoCorrentista ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}