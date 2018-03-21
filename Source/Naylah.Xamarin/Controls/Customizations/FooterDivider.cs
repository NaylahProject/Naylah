﻿using Naylah.Xamarin.Common;
using Naylah.Xamarin.Controls.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Naylah.Xamarin.Controls.Customizations
{
    public class FooterDivider : ContentView
    {
        public FooterDivider()
        {
            Content = new BoxView()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = Device.OnPlatform<double>(0.5, 1, 1),
                BackgroundColor = BootStrapper.CurrentApp.StyleKit.DividerColor,
                IsVisible = Device.OnPlatform<bool>(true, false, true),
            };

        }
    }
}
