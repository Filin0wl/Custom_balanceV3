using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Custom_balanceV3
{
    [ContentProperty("Content")]
    public class StateConditionColor 
    {
        public object State { get; set; }
        public Color StyleColor { get; set; }
    }
}
public enum ColorStates
{
    Positive,
    Negative,
    Undefined
}
