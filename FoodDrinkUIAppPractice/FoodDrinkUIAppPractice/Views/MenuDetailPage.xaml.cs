﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDrinkUIAppPractice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuDetailPage : ContentPage
    {
        public MenuDetailPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MenuDetailViewModel();
        }
    }
}