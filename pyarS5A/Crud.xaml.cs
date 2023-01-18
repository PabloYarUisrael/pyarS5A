using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pyarS5A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Crud : ContentPage
    {
        public const string Url = "http://192.168.167.190:8080/projects/uisrael2023/post.php";

        public Crud()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                client.UploadValues(Url, "POST", parametros);
                    
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Cerrar");
}
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            //Navigation.PopAsync(new MainPage());

        }
    }
}