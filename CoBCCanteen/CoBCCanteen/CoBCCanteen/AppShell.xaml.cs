﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using CoBCCanteen.Views;

namespace CoBCCanteen
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        }

    }
}

