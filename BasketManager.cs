using System.Collections.Generic;

namespace newbuild
{
    public class BasketManager
    {
        private readonly List<string> basketItems;

        public BasketManager()
        {
            basketItems = new List<string>();
        }

        public void AddToBasket(string item)
        {
            basketItems.Add(item);
        }

        public void ClearBasket()
        {
            basketItems.Clear();
        }
    }
}
