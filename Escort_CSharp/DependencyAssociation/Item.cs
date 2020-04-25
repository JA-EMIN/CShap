using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyAssociation
{
    public class Item
    {
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                BindingSystem.GetInstance().ChangeValue(this);
            }
        }
        public override string ToString()
        {
            return Text;
        }
        public Item(string text)
        {
            this.Text = text;
        }
    }
}
