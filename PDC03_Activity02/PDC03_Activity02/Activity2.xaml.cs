﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_Activity02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity2 : ContentPage
    {
        public Activity2()
        {
            InitializeComponent();
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valuelabel.Text=args.NewValue.ToString("F3");
        }
    }
}