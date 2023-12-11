using System.Collections.Generic;
using System.Linq;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        private List<MenuItem> _items = new();

        public IReadOnlyCollection<MenuItem> Items => _items.AsReadOnly();

        public void AddItem(MenuItem item)
        {
            _items.Add(item);
        }

        public decimal GetTotal()
        {
            return _items.Select(i => i.Price).Sum();
        }
    }
}
