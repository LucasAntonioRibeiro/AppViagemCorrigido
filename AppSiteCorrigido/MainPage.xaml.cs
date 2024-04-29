using AppSiteCorrigido.Models;

namespace AppSiteCorrigido
{
    public partial class MainPage : ContentPage
    {
        public static Viagem vg;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void btn_criarPed_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.CriarPedagio());
        }

        private void btn_listped_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.ListarPedagios());
        }

        private async void btn_calcular_Clicked(object sender, EventArgs e)
        {
            if (txt_origem.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o lugar de origem", "Ok");
                return;
            }
            if (txt_destino.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o destino", "Ok");
                return;
            }
            if (txt_distancia.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o valor da distancia", "Ok");
                return;
            }
            if (txt_rendimento == null)
            {
                await DisplayAlert("Erro", "Preencha o valor do rendimento", "Ok");
                return;
            }
            if (txt_combustivel.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o valor do combustivel", "Ok");
                return;
            }

            vg = new Viagem
            {
                Valor_Gasolina = Convert.ToDouble(txt_combustivel.Text),
                Destino = txt_destino.Text,
                Origem = txt_origem.Text,
                Distancia = Convert.ToDouble(txt_distancia.Text),
                Rendimento = Convert.ToDouble(txt_rendimento.Text),
            };

            await Navigation.PushAsync(new Views.CalcularViagem());
        }
    }

}
