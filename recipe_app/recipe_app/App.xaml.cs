﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace recipe_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CarouselPage
            {
                Children =
                {
                    new Pantry(),
                    new Suggestions(),
                    new ShoppingList()
                }
            };
            //var pages = Children.GetEnumerator();
            //pages.MoveNext();
            //CurrentPage = pages.Current;
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
