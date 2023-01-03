using System;
using System.Data;

namespace Cart
{
    class Program
    {
          
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            ProductService productService = new ProductService();

            Console.WriteLine("Welcome to your cart");
            //System.Threading.Thread.Sleep(50);
            while (true)
            {
                
                Console.WriteLine("What do you want to do?");
                var mainMenu = actionService.GetActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                var operation = Console.ReadKey();
                Console.WriteLine();
                
                switch (operation.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        var keyInfo = productService.AddNewProductView(actionService);
                        var id = productService.AddNewProduct(keyInfo.KeyChar);
                        break;
                    case '2':
                        Console.Clear();
                        var removeId = productService.RemoveProductView();
                        productService.RemoveProduct(removeId);
                        break;
                    case '3':
                        Console.Clear();
                        productService.ShowCartContent();
                        break;
                    case '4':
                        Console.Clear();
                        var detailId = productService.ProductDetailSelectionView();
                        productService.ProductDetailView(detailId);
                        break;
                    case '5':
                        Console.Clear();
                        productService.CalculatePriceOfTheCart();
                        break;
                    default:
                        Console.WriteLine("Action you entered does not exist");
                        break;
                }
            }

        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add product", "Main");
            actionService.AddNewAction(2, "Remove product", "Main");
            actionService.AddNewAction(3, "Show products from cart", "Main");
            actionService.AddNewAction(4, "Show product details", "Main");
            actionService.AddNewAction(5, "Show total quantity", "Main");

            actionService.AddNewAction(1, "Food", "AddNewProductMenu");
            actionService.AddNewAction(2, "Beverages", "AddNewProductMenu");
            actionService.AddNewAction(3, "Cosmetics", "AddNewProductMenu");
            actionService.AddNewAction(4, "Household chemicals", "AddNewProductMenu");

            return actionService;
        }


    }
}
