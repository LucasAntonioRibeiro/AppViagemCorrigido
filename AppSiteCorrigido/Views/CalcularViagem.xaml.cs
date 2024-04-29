using AppSiteCorrigido.Models;

namespace AppSiteCorrigido.Views;

public partial class CalcularViagem : ContentPage
{
	
	double total = 0;
	double valor_pedagio = 0;
	public CalcularViagem()
	{
		InitializeComponent();

		lbl_local.Text = "Origem: " + MainPage.vg.Origem;
		lbl_destino.Text = "Destino: " + MainPage.vg.Destino;
		lbl_valor.IsVisible = false;
	}

    private async void btn_sum_Clicked(object sender, EventArgs e)
    {
		double consumo_Carro = ((MainPage.vg.Distancia / MainPage.vg.Rendimento) * MainPage.vg.Valor_Gasolina);

		List<pedagio> pedagios = await App.Db.GetAll();
		foreach (pedagio p in pedagios)
		{
			valor_pedagio += p.valor;
		}

		total = consumo_Carro + valor_pedagio;
		await DisplayAlert("Soma total:", $"Pedagio: {valor_pedagio.ToString("C")}\nConsumo: {consumo_Carro.ToString("C")}\n---------\nTotal: {total.ToString("C")}", "OK");
		lbl_valor.Text = "Valor: " + total.ToString("C");
		lbl_valor.IsVisible = true;
    }

    private void btn_newViagem_Clicked(object sender, EventArgs e)
    {
		Viagem empty_viagem = new Viagem
		{
			Valor_Gasolina = 1.0,
			Rendimento = 1.0,
			Destino = "",
			Distancia = 1.0,
			Origem = "",
		};

		MainPage.vg = empty_viagem;
		Navigation.PushAsync(new MainPage());
    }
}