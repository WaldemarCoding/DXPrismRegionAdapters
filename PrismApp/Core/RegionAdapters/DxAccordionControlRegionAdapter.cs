using System;
using System.Collections.Specialized;
using DevExpress.Xpf.Accordion;
using Prism.Regions;

namespace PrismApp.Core.RegionAdapters
{
    public class DxAccordionControlRegionAdapter : RegionAdapterBase<AccordionControl>
    {
        public DxAccordionControlRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, AccordionControl regionTarget)
        {
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }
            if (regionTarget == null)
            {
                throw new ArgumentNullException(nameof(regionTarget));
            }

            region.Views.CollectionChanged += (sender, args) =>
            {
                if (args.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (var view in args.NewItems)
                    {
                        AddViewToRegion(view, regionTarget);
                    }
                }
                else if (args.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (var view in args.OldItems)
                    {
                        RemoveViewFromRegion(view, regionTarget);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }

        private void AddViewToRegion(object view, AccordionControl regionTarget)
        {
            if (view is AccordionItem accordionItem)
            {
                regionTarget.Items.Add(accordionItem);
                if (regionTarget.SelectedRootItem == null)
                {
                    regionTarget.SelectedRootItem = view;
                }
            }
        }

        private void RemoveViewFromRegion(object view, AccordionControl regionTarget)
        {
            if (view is AccordionItem accordionItem)
            {
                regionTarget.Items.Remove(accordionItem);
            }
        }
    }
}
