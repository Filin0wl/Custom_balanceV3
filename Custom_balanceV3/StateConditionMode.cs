using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Custom_balanceV3
{
    [ContentProperty("Content")]
    public class StateConditionMode : View
    {
        public object State { get; set; }
        public View Content { get; set; }
    }

    public enum States
    {
        Collapsed,
        Expanded,
        Error
    }
}
