using System.Linq;
using DevExpress.Xpf.Accordion;
using DevExpress.Xpf.Core;
using PrismApp.Core;

namespace PrismApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private readonly IApplicationCommands _applicationCommands;

        public MainWindow(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;
            InitializeComponent();
        }

        private void AccordionControl_OnSelectedRootItemChanged(object sender, AccordionSelectedRootItemChangedEventArgs e)
        {
            if (((AccordionControl)sender).SelectedRootItem is IAccordionRootItem root)
            {
                _applicationCommands.NavigateCommand.Execute(root.DefaultNavigationPath);
                AccordionControl.SelectedItem = ((AccordionItem)root).Items.FirstOrDefault();
            }
        }

        private void AccordionControl_OnSelectedItemChanged(object sender, AccordionSelectedItemChangedEventArgs e)
        {
            if (((AccordionControl)sender).SelectedItem is NavigationItem child)
            {
                if (!string.IsNullOrEmpty(child.NavigationPath))
                {
                    _applicationCommands.NavigateCommand.Execute(child.NavigationPath);
                }
            }
        }
    }
}
