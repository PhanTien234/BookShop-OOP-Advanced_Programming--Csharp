using BookShop;

Main();

void Main()
{
    ShopBook shop = new ShopBook();
    int option;
    while (true)
    {
        ShowMenu();
        Console.WriteLine("Enter your option: ");
        option = int.Parse(Console.ReadLine());
        int id;
        string title;
        switch (option)
        {
            case 1:
                while (true)
                {
                    Console.WriteLine("Enter \"a\" to Input normal book");
                    Console.WriteLine("Enter \"b\" to Input gold book");
                    Console.WriteLine("Enter \"e\" to Exit");
                    Console.WriteLine("Enter your choice ");
                    string choice = Console.ReadLine();
                    if (choice.Equals("a"))
                    {
                        shop.InputNormalBook();
                    }
                    else if(choice.Equals("b"))
                    {
                        shop.InputGoldenBook();
                    }
                    else if(choice.Equals("e"))
                    {
                        break;
                    }
                } 
                break;
                
            case 2:
                shop.Display();
                break;
            case 3:
                id = int.Parse(Console.ReadLine());
                shop.FindNormalBookById(id);
                break;
            case 4:
                title = Console.ReadLine();
                shop.FindNormalBooksByTitle(title);
                break;
            case 5:
                id = int.Parse(Console.ReadLine());
                shop.FindGoldenBookById(id);
                break;
            case 6:
                title = Console.ReadLine();
                shop.FindGoldenBooksByTitle(title);
                break;
            case 7:
                id = int.Parse(Console.ReadLine());
                shop.RemoveNormalBookById(id);
                break;
            case 8:
                id = int.Parse(Console.ReadLine());
                shop.RemoveGoldenBookById(id);
                break;
            case 9:
                id = int.Parse(Console.ReadLine());
                shop.UpdateNormalBookById(id);
                break;
            case 10:
                id = int.Parse(Console.ReadLine());
                shop.UpdateGoldenBookById(id);
                break;
            case 11:
                Console.WriteLine("You exited! ");
                return;
        }

    }
    
}

static void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("______________* * * BOOK SHOP * * *__________");
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("|  1: To add books                           |");
    Console.WriteLine("|  2. To show information of all book        |");
    Console.WriteLine("|  3. To show Normal books by Id             |");
    Console.WriteLine("|  4. To show Normal books by title          |");
    Console.WriteLine("|  5. To show Golden books by Id             |");
    Console.WriteLine("|  6. To show Golden books by title          |");
    Console.WriteLine("|  7. To remove Normal book by id            |");
    Console.WriteLine("|  8. To remove Golden book by id            |");
    Console.WriteLine("|  9. To update Normal book by id            |");
    Console.WriteLine("|  10. To update Normal book by id           |");
    Console.WriteLine("|  11. To Exit                               |");
    Console.WriteLine("_____________________________________________");
}