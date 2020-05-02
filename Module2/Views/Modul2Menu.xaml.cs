using DevExpress.Xpf.Accordion;
using PrismApp.Core;

namespace Module2.Views
{
    /// <summary>
    /// Interaction logic for AccordionMenuItem.xaml
    /// </summary>
    public partial class Modul2Menu : AccordionItem, IAccordionRootItem
    {
        public Modul2Menu()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => nameof(ViewC);
    }
}
