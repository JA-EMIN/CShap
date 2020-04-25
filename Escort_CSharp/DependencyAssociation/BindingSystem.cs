using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyAssociation
{
   public class BindingSystem
    {
        public event ValueChangedEventHandler ValueChangedEventHandler = null;
        static BindingSystem bs = null;
        public static BindingSystem GetInstance()
        {
            if (bs == null)
                bs = new BindingSystem();
            return bs;
        }
        private BindingSystem()
        {
            
        }
        public void ChangeValue(Item item)
        {
            if (ValueChangedEventHandler != null)
                ValueChangedEventHandler(null, new ValueChangedEventArgs(item));
        }



    }
}
