using System.Collections.Generic;

namespace lab13.ViewModels
{
    public class OrderViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }
        public string ZipCode { get; set; }

        public string Payment { get; set; }

        public IEnumerable<CartItemViewModel> Items { get; set; }
    }
}