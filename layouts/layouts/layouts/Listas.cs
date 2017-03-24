using System;
using Xamarin.Forms;


namespace layouts
{
    class Listas : ContentPage
    {
        public Listas()
        {
            Title = "Xamarin.Forms- Listados";
            var listView = new ListView();
            listView.ItemsSource = new ListItemPage[]
            {
                new ListItemPage { Title = "Listado de datos",
                        PageType = typeof(ListViewDataModel)}

            };
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as ListItemPage;
                if (item == null) return;
                Page page = (Page)Activator.CreateInstance(item.PageType);
                await Navigation.PushAsync(page);
                listView.SelectedItem = null;
            };
            Content = listView;
        }

        private class ListItemPage
        {
            public string Title { get; set; }
            public Type PageType { get; set; }
        }
    }
}
