using Xamarin.Forms;
using System;
using System.Collections.Generic;

public class PickerSlider : ContentPage
{
     Label evento;
     Label valorPage;
    public PickerSlider()
	{
        evento = new Label();
        evento.Text = "valores en la etiqueta";
        valorPage = new Label
        {
            Text = "valoren la pagina"
        };
        Picker selector = new Picker
        {
            Title = "Opciones",
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        var listadoOpciones = new List<string> { "Primero","Segundo","Tercero"};
        foreach(string paquito in listadoOpciones)
        {
            selector.Items.Add(paquito);
        }
        selector.SelectedIndexChanged += (sender, args) =>
        {
            valorPage.Text = selector.Items[selector.SelectedIndex];
        };
        DatePicker fecha = new DatePicker
        {
            Format = "D",
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        fecha.DateSelected += (object sender, DateChangedEventArgs arg) =>
         {
             evento.Text = arg.NewDate.ToString();
             valorPage.Text = fecha.Date.ToString();
         };
        TimePicker tiempo = new TimePicker
        {
            Format = "T",
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        tiempo.PropertyChanged += (sender, e) =>
        {
            if(e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                valorPage.Text = tiempo.Time.ToString();
            }
        };

        this.Content = new StackLayout
        {
            HorizontalOptions = LayoutOptions.Center,
            Children =
            {
                valorPage,
                evento,
                selector,
                fecha,
                tiempo
            }
        };

	}
}
