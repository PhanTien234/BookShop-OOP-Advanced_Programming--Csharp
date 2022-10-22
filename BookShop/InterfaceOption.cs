namespace BookShop;

public class InterfaceOption
{
    public static void PrintMenu()
        {
            Console.WriteLine("\t\t\t\t\t=========Welcome to program=========");
            Console.WriteLine("\t\t\t\t\t====================================");
        }
        public static int EnterMenuOptions()
        {
            Console.WriteLine("\t\t\t\t|\t1: To add books                    \t|");
            Console.WriteLine("\t\t\t\t|\t2: To show information of all books\t|");
            Console.WriteLine("\t\t\t\t|\t3: To show book by id              \t|");
            Console.WriteLine("\t\t\t\t|\t4: To show books by title          \t|");
            Console.WriteLine("\t\t\t\t|\t5: To remove book by id            \t|");
            Console.WriteLine("\t\t\t\t|\t6: To update book by id            \t|");
            Console.WriteLine("\t\t\t\t|\t10: To exit                        \t|");
            Console.Write("\t\t\t\t\tEnter your choice:  ");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterBook()
        {
            Console.WriteLine("\t\t\t\t\t====================================");
            Console.WriteLine("\t\t\t\t|\t   Enter \"a\" for normal book     \t|");
            Console.WriteLine("\t\t\t\t|\t   Enter \"b\" for GE book         \t|");
            Console.WriteLine("\t\t\t\t|\t   Enter \"v\" to exit             \t|");
            Console.Write("\t\t\t\t\tEnter your choice:  ");
            return Console.ReadLine();
        }
        public static int EnterId()
        {
            
            Console.Write("Enter ID:     ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }
        public static string EnterTitle()
        {
            Console.Write("Enter title:  ");
            string title = Console.ReadLine();
            return title;
        }
        public static string EnterAuthor()
        {
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            return author;
        }
        public static decimal EnterPrice()
        {
            Console.Write("Enter price:  ");
            decimal price = decimal.Parse(Console.ReadLine());
            return price;
        }
        public static int EnterQuantity()
        {
            Console.Write("Enter quantity:  ");
            int quantity = int.Parse(Console.ReadLine());
            return quantity;
        }
        public static string ShowMessage(bool result)
        {
            if (!result) return "FAILED!!!!!!";
            return "SUCCESSFULLY!!!";
        }
        public static void ToScreen(string str)
        {
            Console.WriteLine(str);
        }
}