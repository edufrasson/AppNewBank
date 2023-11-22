using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNewBank.View.Funcoes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceberPix : ContentPage
    {
        public ReceberPix()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string teste = "Chave da Transferência: tiago@tiago.blog.br ";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(teste, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            img_qrcode.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }
    }
}