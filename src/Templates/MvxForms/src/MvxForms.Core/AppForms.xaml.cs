﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross.Forms.Platform;
using Xamarin.Forms;

namespace MvxForms.Core
{
    public partial class AppForms : MvxFormsApplication
    {

        public AppForms()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
