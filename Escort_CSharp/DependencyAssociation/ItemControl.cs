using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyAssociation
{
    public class ItemControl
    {
        
        private bool isShow = false;
        public Item Item
        {
            get;
            private set;
        }
        public string Text
        {
            get
            {
                return Item.Text;
            }
        }
        public ItemControl(Item item)
        {
            this.Item = item;
            BindingSystem.GetInstance().ValueChangedEventHandler += ItemControl_ValueChangedEventHandler;
        }

        private void ItemControl_ValueChangedEventHandler(object sender, ValueChangedEventArgs e)
        {
            if((e.Item == Item) && isShow)
            {
                Show();
            }
        }

        public void Show()
        {
            isShow = true;
            Console.WriteLine(Item.Text);
        }
    }
}
