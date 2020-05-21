using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo
{
    public partial class NavPage : NavigationPage
    {
        public NavPage()
        {
            InitializeComponent();

            SetHasBackButton(this, true);
        }

        public NavPage(Page root) : base(root)
        {
            InitializeComponent();

            SetHasBackButton(this, true);
        }

        public bool IgnoreLayoutChange { get; set; } = false;

        protected override void OnSizeAllocated(double width, double height)
        {
            if (!IgnoreLayoutChange)
                base.OnSizeAllocated(width, height);
        }
    }
}
