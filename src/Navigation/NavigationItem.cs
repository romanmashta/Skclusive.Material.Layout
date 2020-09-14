using System;
using Microsoft.AspNetCore.Components;
using Skclusive.Material.Core;

namespace Skclusive.Material.Layout
{
    public class NavigationItem
    {
        public string Title { set; get; }

        public string ResourcePath { set; get; }

        public string Icon { set; get; }

        public bool Active { set; get; }
        public Action OnActivate { get; set; }
        public int? Badge { get; set; }
        public bool IsPrimary { get; set; }
    }
}
