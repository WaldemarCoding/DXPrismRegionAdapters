using System.Collections.ObjectModel;
using Prism.Mvvm;
using PrismApp.Core;

namespace Module1.ViewModels
{
    public class Modul1MenuViewModel : BindableBase
    {
        public ObservableCollection<NavigationItem> Items { get; set; } = new ObservableCollection<NavigationItem>();

        public Modul1MenuViewModel()
        {
            GenerateMenu();
        }

        void GenerateMenu()
        {
            Items.Add(new NavigationItem { Header = "go to ViewA", NavigationPath = "ViewA" });
            Items.Add(new NavigationItem { Header = "go to ViewB", NavigationPath = "ViewB" });
        }
    }
}
