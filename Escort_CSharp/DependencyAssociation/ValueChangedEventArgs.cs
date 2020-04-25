using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyAssociation
{
    public delegate void ValueChangedEventHandler(object sender, ValueChangedEventArgs e);
    public class ValueChangedEventArgs : EventArgs
    {
        public string Text
        {
            get
            {
                return Item.Text;
            }
        }
        public Item Item
        {
            get;
            private set;
        }
        public ValueChangedEventArgs(Item e)
        {
            this.Item = e;
        }
    }
}
