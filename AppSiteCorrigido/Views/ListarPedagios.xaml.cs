using AppSiteCorrigido.Models;
using System.Collections.ObjectModel;

namespace AppSiteCorrigido.Views;

public partial class ListarPedagios : ContentPage
{
	ObservableCollection<pedagio> lista_pedagios = new ObservableCollection<pedagio>();
	public ListarPedagios()
	{
		InitializeComponent();
		lst_pedagios.ItemsSource = lista_pedagios;
	}

	protected async override void OnAppearing()
	{
		if (lista_pedagios.Count ==0)
		{
			List<pedagio> tmp = await App.Db.GetAll();
			foreach (pedagio p in tmp)
			{
				lista_pedagios.Add(p);
			}
		}
	}
}