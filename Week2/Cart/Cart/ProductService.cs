using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    public class ProductService
    {
        public List<Product> Products { get; set; }
        public ProductService()
        {
            Products = new List<Product>();
        }

        public ConsoleKeyInfo AddNewProductView(MenuActionService actionService)
        {
            var addNewProductMenu = actionService.GetActionsByMenuName("AddNewProductMenu");
            Console.WriteLine("Please select product type: ");
            for (int i = 0; i < addNewProductMenu.Count; i++)
            {
                Console.WriteLine($"{addNewProductMenu[i].Id}. {addNewProductMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            Console.WriteLine();
            return operation;
        }

        public int AddNewProduct(char productType)
        {
            int productTypeId;
            Int32.TryParse(productType.ToString(),out productTypeId);
            Product product = new Product();
            product.TypeId = productTypeId;
            int productId = Products.Count == 0 ? 1 : Products[^1].Id + 1;
            Console.WriteLine("Please enter name for new product");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter quantity of new product");
            var quantity = Console.ReadLine();
            decimal productQuantity;
            Decimal.TryParse(quantity, NumberStyles.Any, CultureInfo.InvariantCulture, out productQuantity);
            Console.WriteLine("Please enter price of new product");
            var price = Console.ReadLine();
            decimal productPrice;
            Decimal.TryParse(price, NumberStyles.Any, CultureInfo.InvariantCulture, out productPrice);
            
            product.Id = productId;
            product.Name = name;
            product.Quantity = productQuantity;
            product.Price = productPrice;

            Products.Add(product);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{product.Name} was added.");
            Console.ForegroundColor = ConsoleColor.Gray;
            return productId;
        }
        public int RemoveProductView()
        {
            Console.Write("Please enter id of product you want to remove: Available id:");
            if (Products.Count > 0)
            {
                foreach (var product in Products)
                {
                    Console.Write($" {product.Id}");
                }
            }
            Console.WriteLine();
            var productId = Console.ReadKey();
            int id;
            Int32.TryParse(productId.KeyChar.ToString(), out id);

            return id;
        }

        public void RemoveProduct(int removeId)
        {
            Product productToRemove = new Product();
            foreach (var product in Products)
            {
                if(product.Id== removeId)
                {
                    productToRemove = product;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{productToRemove.Name} was removed.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
            }
            Products.Remove(productToRemove);
        }

        public void ShowCartContent()
        {
            Console.WriteLine(Products.ToStringTable(new[] { "Id", "Name", "Quantity", "Price" }, a => a.Id, a => a.Name, a=> a.Quantity, a => a.Price));

        }

        public int ProductDetailSelectionView()
        {
            
            Console.Write($"Please enter id of product you want to show. Available id:");
            if (Products.Count > 0)
            {
                foreach(var product in Products)
                {
                    Console.Write($" {product.Id}");
                }
            }
            Console.WriteLine();
            var productId = Console.ReadKey();
            int id;
            Int32.TryParse(productId.KeyChar.ToString(), out id);

            return id;
        }

        public void ProductDetailView(int detailId)
        {
            Product productToShow = new Product();
            foreach (var product in Products)
            {
                if (product.Id == detailId)
                {
                    productToShow = product;
                    break;
                }
            }

            Console.WriteLine($"\nProduct id: {productToShow.Id}");
            Console.WriteLine($"Product name: {productToShow.Name}");
            Console.WriteLine($"Product type id: {productToShow.TypeId}");
            Console.WriteLine($"Product quantity: {productToShow.Quantity}");
            Console.WriteLine($"Product Price: {productToShow.Price}");

        }

        public void CalculatePriceOfTheCart()
        {
            decimal totalPrice = 0;

            foreach(var product in Products)
            {
                totalPrice += product.Quantity * product.Price;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Total price of you car is {totalPrice}$.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
