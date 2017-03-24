using Xamarin.Forms;
using System;
namespace layouts
{
    public class Articulo { 
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }
    class ListViewDataModel : ContentPage
    {
        public ListViewDataModel()
        {
            var lista = new ListView();
            lista.ItemsSource = new Articulo[]
            {
                new Articulo { Titulo = "Numero 1", Descripcion="primera"},
                new Articulo { Titulo = "Numero 2", Descripcion="segundo"}    
            };
            lista.ItemTemplate = new DataTemplate(typeof(TextCell));
            lista.ItemTemplate.SetBinding(TextCell.TextProperty, "Titulo");
            lista.ItemTemplate.SetBinding(TextCell.DetailProperty, "Descripcion");

            Content = lista;
            lista.ItemTapped += async (sender, args) =>
            {
                Articulo articuloSeleccionado = (Articulo)args.Item;
                await DisplayAlert("Seleccionado", articuloSeleccionado.Titulo, "OK");
                ((ListView)sender).SelectedItem = null;
            };
               
        }
    }
}
