using Xamarin.Forms;
using System;

namespace layouts
{
    class Menu : ContentPage
    {
        public Menu()
        {
            Command<Type> navigationCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await this.Navigation.PushAsync(page);
            }
            );
            this.Title = "Clases de Xamarin";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("layouts")
                    {
                        new TextCell
                        {
                            Text ="Stack Layout /primera clase",
                            Command = navigationCommand,
                            CommandParameter = typeof(PrimeraLayout)
                        },
                        new TextCell
                        {
                            Text = "Segunda Clase layouts / Relative",
                            Command = navigationCommand,
                            CommandParameter = typeof(SegundaLayout)
                        },
                        new TextCell {
                            Text = "Sliders y Pickers",
                            Command = navigationCommand,
                            CommandParameter = typeof(PickerSlider)
                        },new TextCell {
                            Text = "Listados",
                            Command = navigationCommand,
                            CommandParameter = typeof(Listas)
                        }
                    }
                }
            };
        }


    }
}
