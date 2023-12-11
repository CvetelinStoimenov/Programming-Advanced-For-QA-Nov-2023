
using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        private List<Order> _orderHistrory = new();
        public IReadOnlyCollection<Order> OrderHistrory => this._orderHistrory.AsReadOnly();
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string  name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public void AddOrder(Order order)
        {
            this._orderHistrory.Add(order);
        }
    }
}
