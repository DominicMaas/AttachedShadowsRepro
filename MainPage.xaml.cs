using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace AttachedShadowRepro
{
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<MyModel> MyCollection { get; } = new ObservableCollection<MyModel>();

        public MainPage()
        {
            InitializeComponent();

            for (var i = 0; i < 20; i++)
            {
                MyCollection.Add(new MyModel { Name = $"Item {i}", ImageLink = "https://via.placeholder.com/300" });
            }
        }
    }

    public class MyModel : ObservableObject
    {
        public string Name { get; set; }
        public string ImageLink { get; set; }
    }
}
