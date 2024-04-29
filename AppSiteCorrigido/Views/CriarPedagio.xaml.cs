using AppSiteCorrigido.Models;

namespace AppSiteCorrigido.Views;

public partial class CriarPedagio : ContentPage
{
	public CriarPedagio()
	{
		InitializeComponent();
	}

    private async void btn_enviar_Clicked(object sender, EventArgs e)
    {
		try  
		{
			pedagio p = new pedagio();
			p.local = txt_local.Text;
			p.valor = Convert.ToDouble(txt_valor.Text);

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Pedagio foi registrado", "Ok");
		}
		catch (Exception ex)
		{
			await DisplayAlert ("Erro", ex.Message, "Ok");
		}
    }
}