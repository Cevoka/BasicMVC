using Microsoft.AspNetCore.Mvc;
using BasicMVC.Models;
using BasicMVC.ViewModels;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek müşteri oluşturma
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Email = "ahmet.yilmaz@email.com"
            };

            // Örnek siparişler oluşturma
            var orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    ProductName = "Laptop",
                    Price = 15000.00m,
                    Quantity = 1
                },
                new Order
                {
                    Id = 2,
                    ProductName = "Mouse",
                    Price = 250.00m,
                    Quantity = 2
                },
                new Order
                {
                    Id = 3,
                    ProductName = "Klavye",
                    Price = 450.00m,
                    Quantity = 1
                }
            };

            // ViewModel oluşturma ve veri atama
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
} 