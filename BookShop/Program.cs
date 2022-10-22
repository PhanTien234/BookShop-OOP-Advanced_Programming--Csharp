using BookShop;

Main();

void Main()
{
   ShopBook shop = new ShopBook();
            int input = Option.INIT;
            string inputBook = Option.INPUT_BOOK;

            shop.AddBook(new Book(1, "The Astronomy Book", "Dorling Kindersley", 24, 2000));
            shop.AddBook(new Book(2, "The Astronomy Book", "Adams Media", 15, 1000));
            shop.AddBook(new Book(3, "Cloud Computing", "Guo", 56, 900));
            shop.AddBook(new Book(4, "Rich Dad Poor Dad", "Robert T. Kiyosaki", 10, 2000));
            shop.AddBook(new Book(5, "The Power of Habit", "Charles Duhigg", 13, 2005));
            shop.AddBook(new GoldenEditionBook(50, "Self Discipline", "Dorling Kindersley", 24, 99));
            shop.AddBook(new GoldenEditionBook(51, "The power of NOW", "Eckhart Tolle", 40, 100));
            shop.AddBook(new GoldenEditionBook(52, "mindset", "Carol S.Dweck", 60, 30));
            shop.AddBook(new GoldenEditionBook(53, "Atomic Habits", "James Clear", 50, 20));
            while (input != Option.EXIT)
            {
                input = InterfaceOption.EnterMenuOptions();
                switch (input)
                {
                    case Option.ADD_BOOK:
                        do
                        {
                            inputBook = InterfaceOption.EnterBook();
                            switch (inputBook)
                            {
                                case Option.ADD_NORMAL_BOOK:
                                    try
                                    {
                                        shop.AddBook(new Book(
                                        InterfaceOption.EnterId(),
                                        InterfaceOption.EnterTitle(),
                                        InterfaceOption.EnterAuthor(),
                                        InterfaceOption.EnterPrice(),
                                        InterfaceOption.EnterQuantity()));
                                    }catch(ArgumentException ae)
                                    {
                                        InterfaceOption.ToScreen(ae.Message);
                                    }
                                    break;
                                case Option.ADD_GOLD_EDITION_BOOK:
                                    try
                                    {
                                        shop.AddBook(new GoldenEditionBook(
                                        InterfaceOption.EnterId(),
                                        InterfaceOption.EnterTitle(),
                                        InterfaceOption.EnterAuthor(),
                                        InterfaceOption.EnterPrice(),
                                        InterfaceOption.EnterQuantity()));
                                    }catch (ArgumentException ae)
                                    {
                                        InterfaceOption.ToScreen(ae.Message);
                                    }
                            break;
                                default:
                                    break;
                            }
                        } while (inputBook != Option.EXIT_ENTER_BOOK);
                        break;
                    case Option.SHOW_ALL_BOOKS:
                        InterfaceOption.ToScreen(shop.PrintInformation());
                        break;
                    case Option.SHOW_BY_ID:
                        InterfaceOption.ToScreen(shop.FindBookById(InterfaceOption.EnterId()));
                        break;
                    case Option.SHOW_BY_NAME:
                        InterfaceOption.ToScreen(shop.FindBooksByName(InterfaceOption.EnterTitle()));
                        break;
                    case Option.REMOVE_BOOK:
                        InterfaceOption.ToScreen(InterfaceOption.ShowMessage(shop.RemoveBookById(InterfaceOption.EnterId())));
                        break;
                    case Option.UPDATE_BOOK:
                        InterfaceOption.ToScreen(InterfaceOption.ShowMessage(shop.UpdateBookById(
                            InterfaceOption.EnterId(),
                            InterfaceOption.EnterTitle(),
                            InterfaceOption.EnterAuthor(),
                            InterfaceOption.EnterPrice(),
                            InterfaceOption.EnterQuantity()
                            )));
                        break;
                    case Option.EXIT:
                        return;
                    default:
                        break;
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