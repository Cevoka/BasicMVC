using BasicMVC.Models;

namespace BasicMVC.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; } = new Customer();
        public List<Order> Orders { get; set; } = new List<Order>();
    }
} 