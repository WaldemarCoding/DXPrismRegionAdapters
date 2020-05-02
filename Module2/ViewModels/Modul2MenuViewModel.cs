using System.Collections.ObjectModel;
using Prism.Mvvm;
using PrismApp.Core;

namespace Module2.ViewModels
{
    public class Modul2MenuViewModel : BindableBase
    {
        public ObservableCollection<NavigationItem> Items { get; set; } = new ObservableCollection<NavigationItem>();

        public Modul2MenuViewModel()
        {
            GenerateMenu();
        }

        void GenerateMenu()
        {
            Items.Add(new NavigationItem { Header = "go to ViewC", NavigationPath = "ViewC" });
        }
    }
}
