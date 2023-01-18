using Newtonsoft.Json;
using pyarS5A.ws;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pyarS5A
{
    public partial class MainPage : ContentPage
    {
        public const string Url = "http://192.168.167.190:8080/projects/uisrael2023/post.php";
        private readonly HttpClient _client = new HttpClient();
        private ObservableCollection<Datos> _post;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Get_Clicked(object sender, EventArgs e)
        {
            var content = await _client.GetStringAsync(Url);
            List<Datos> posts = JsonConvert.DeserializeObject<List<Datos>>(content);
            _post = new ObservableCollection<Datos>(posts);
            MyListView.ItemsSource = posts;
        }
    }
}
