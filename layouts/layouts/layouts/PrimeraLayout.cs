using Xamarin.Forms;

namespace layouts
{
    class PrimeraLayout : ContentPage
    {
        public PrimeraLayout()
        {
            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                Children =
                {
                    new Label{
                        Text = "Inicio a la izquierda",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "etiqueta al centro",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "etiqueta a la derecha",
                        HorizontalOptions = LayoutOptions.End
                    }
                }
            };

            StackLayout stackLayout2 = new StackLayout
            {
                Spacing = 0,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label
                    {
                        Text = "Inicio"
                    },
                    new Label
                    {
                        Text = "Centro",
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    },
                    new Label
                    {
                        Text = "Fin",
                    }
                }
            };
            StackLayout stackLayout3 = new StackLayout
            {
                Children =
                {
                    stackLayout,
                    stackLayout2
                }
            };

            this.Title = "Primera Layout";
            this.Content = stackLayout3;
        }

        

    }
}
