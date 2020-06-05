using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Custom_balanceV3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BalanceItem : ContentView
    {

        static StateContainerMode container = new StateContainerMode();

        

        public static readonly BindableProperty StateProperty = BindableProperty.Create(nameof(State), typeof(string), typeof(BalanceItem), null, BindingMode.Default, null, StateChanged);

        public object State
        {
            get { return GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }
        private static async void StateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var parent = bindable as BalanceItem;
            if (parent != null)
            {
                container.State = (string)newValue;

            }

        }



        /// <summary>
        /// ////////////////////////////////////////
        /// </summary>


        public static readonly BindableProperty ColorProperty =
           BindableProperty.Create(nameof(StateColor),
                                   typeof(string), typeof(BalanceItem),
                                   null, propertyChanged: onChangedStateColor);

        public object StateColor
        {
            get { return GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        private static async void onChangedStateColor(BindableObject bindable, object oldValue, object newValue)
        {
            var parent = bindable as BalanceItem;
            if (parent != null)
            {
                Color colorStyle = newValue == "Positive" ? Color.FromHex("#66cc99") : newValue == "Negative" ? Color.FromHex("#ff1a68") :  Color.Gray;
                parent.frame.BorderColor = colorStyle;
                parent.labelPLC.TextColor = colorStyle;
                parent.labelPLE.TextColor = colorStyle;
            }
        }

        

        public BalanceItem()
        {

            InitializeComponent();
            BindingContext = container;

        }

        private void TapFrame(object sender, EventArgs e)
        {
            if (container.State == "Collapsed")
            {
                container.State = "Expanded";
            }
            else
            {
                container.State = "Collapsed";
            }
        }
    }
}