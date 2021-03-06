﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Controls
{
    public partial class TabbedImageLabelView : ContentView
    {
        string labelText = "主页";
        Color labelColor = Color.Gray;

        public TabbedImageLabelView()
        {
            InitializeComponent();
        }


        #region LabelColor

        public static readonly BindableProperty LabelColorProperty =
            BindableProperty.Create("LabelColor",
                typeof(Color),
                typeof(TabbedImageLabelView),
                Color.Gray,
                propertyChanged: LabelColorPropertyChanged);

        private static void LabelColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var tab = (TabbedImageLabelView)bindable;
            tab.label.TextColor = (Color)newValue;

        }
        public Color LabelColor
        {
            get { return (Color)GetValue(LabelColorProperty); }
            set
            {
                SetValue(LabelColorProperty, value);
            }
        }
        #endregion

        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;
                label.Text = labelText;
            }
        }

        #region ImageSource
        public static readonly BindableProperty ImageSourceProperty =
            BindableProperty.Create("ImageSource",
        typeof(string),
        typeof(TabbedImageLabelView),
        "Icon.png",
        propertyChanged: ImageSourcePropertyChanged);

        private static void ImageSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var tab = (TabbedImageLabelView)bindable;
            tab.image.Source = (string)newValue;

        }

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set
            {
                SetValue(ImageSourceProperty, value);
            }
        }
        #endregion
    }
}
