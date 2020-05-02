using DevExpress.Xpf.Accordion;
using PrismApp.Core;

namespace Module1.Views
{
    /// <summary>
    /// Interaction logic for AccordionMenuItem.xaml
    /// </summary>
    public partial class Modul1Menu : AccordionItem, IAccordionRootItem
    {
        public Modul1Menu()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => nameof(ViewA);
    }
}
