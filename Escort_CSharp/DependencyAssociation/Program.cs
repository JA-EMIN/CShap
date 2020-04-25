using System;

namespace DependencyAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Item item = new Item("나나나");
            ItemControl ic = new ItemControl(item);
            ic.Show();
            item.Text = "너너너";
        }
    }
}
