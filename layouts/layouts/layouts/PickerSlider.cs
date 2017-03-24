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
        Stepper escalon = new Stepper
        {
            Minimum = 0,
            Maximum = 10,
            Increment = 1,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        escalon.ValueChanged += (sender, ev) =>
        {
            evento.Text = String.Format("El valor de" +
                        "stepper es{0:F1}", ev.NewValue);
            valorPage.Text = escalon.Value.ToString();
        };
        Slider deslizador = new Slider
        {
            Minimum = 0,
            Maximum = 100,
            Value = 50,
            VerticalOptions= LayoutOptions.CenterAndExpand,
            WidthRequest = 300
        };
        deslizador.ValueChanged += (sender, parametros) =>
         {
             evento.Text = String.Format("el slider es {0:F1}"
                                   , parametros.NewValue);
             valorPage.Text = deslizador.Value.ToString();
         };

        Switch sw = new Switch
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand

        };
        sw.Toggled += (sender, ev)=>{
            evento.Text = String.Format("el switch "
                                +"es {0}",ev.Value);
            valorPage.Text = sw.IsToggled.ToString();
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
                tiempo,
                escalon,
                deslizador,
                sw
            }
        };

	}
}
