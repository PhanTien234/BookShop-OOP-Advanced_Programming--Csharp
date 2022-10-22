﻿namespace BookShop;

public class ShopBook
{
    private List<Book> books = new List<Book>();
    private List<GoldenEditionBook> goldenEditionBooks = new List<GoldenEditionBook>();

    public void InputNormalBook()
    {
        Console.WriteLine("Enter the number of  normal book you want to add: ");
        var countBook = int.Parse(Console.ReadLine());
        for (int i = 0; i < countBook; i++)
        {
            Console.Write("Enter ID of book: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter the price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            var book = new Book(id, title, author, price, quantity);
            AdddNormalBook(book);
        }
    }

    public void AdddNormalBook(Book book)
    {
        if (CheckIdNormalBook(book.Id))
        {
            throw new ArgumentException("ID is existed! Please create by another ID");
        }
        else
        {
            books.Add(book);
        }
    }
    public bool CheckIdNormalBook(int id)
    {
        Book bookInList = books.FirstOrDefault(i => i.Id.Equals(id));
        if (bookInList != null) return true;
        return false;
    }
    
    public void InputGoldenBook()
    {
        Console.WriteLine("Enter the number of  golden book you want to add: ");
        var countBook = int.Parse(Console.ReadLine());
        for (int i = 0; i < countBook; i++)
        {
            Console.Write("Enter ID of book: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter the price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            var goldenBook = new GoldenEditionBook(id, title, author, price, quantity);
            AddGoldenBook(goldenBook);
        }
    }

    public void AddGoldenBook(GoldenEditionBook goldenEditionBook)
    {
        if (CheckIdGoldenBook(goldenEditionBook.Id))
        {
            throw new ArgumentException("ID is existed! Please create by another ID");
        }
        else
        {
            goldenEditionBooks.Add(goldenEditionBook);
        }
    }
    public bool CheckIdGoldenBook(int id)
    {
        GoldenEditionBook goldenBookInList = goldenEditionBooks.FirstOrDefault(i => i.Id.Equals(id));
        if (goldenBookInList != null) return true;
        return false;
    }
    
    public void Display()
    {
        Console.WriteLine("___________________________________* * *List of Normal Book* * *___________________________________");
        for (int i = 0; i < books.Count; i++)
        {
            Console.Write(books[i].PrintInformation());
        }
        Console.WriteLine("|__________________________________________________END______________________________________________|");
        Console.WriteLine();
        Console.WriteLine(" _____________________________________* * *List of Golden Book* * *______________________________________");
        for (int i = 0; i < goldenEditionBooks.Count; i++)
        {
            Console.Write(goldenEditionBooks[i].PrintInformation());
        }
        Console.WriteLine("|__________________________________________________END___________________________________________________|");
    }
    
    public void FindNormalBookById(int id)
    {
        Book bookInList = books.FirstOrDefault(i => i.Id.Equals(id));
        if (bookInList != null )
        {
            Console.WriteLine(bookInList.PrintInformation());
        }

    }
    
    public void FindNormalBooksByTitle(string title)
    {
        foreach (var b in books.Where(n =>n.Title.Equals(title)))
        {
            Console.WriteLine(b.PrintInformation());
        }

    }
    
    public void FindGoldenBookById(int id)
    {
        GoldenEditionBook goldenBookInList = goldenEditionBooks.FirstOrDefault(i => i.Id.Equals(id));
        if (goldenBookInList != null )
        {
            Console.WriteLine(goldenBookInList.PrintInformation());
        }

    }
    
    public void FindGoldenBooksByTitle(string title)
    {
        foreach (var goldenBook in goldenEditionBooks.Where(n =>n.Title.Equals(title)))
        {
            Console.WriteLine(goldenBook.PrintInformation());
        }
    }
    
    public void RemoveNormalBookById(int id)
    {
        Book bookInList = books.FirstOrDefault(i => i.Id.Equals(id));
        if (bookInList != null)
        {
            books.Remove(bookInList);
            Console.WriteLine("Remove successfully!");
        }
    }
    public void RemoveGoldenBookById(int id)
    {
        GoldenEditionBook goldenBookInList = goldenEditionBooks.FirstOrDefault(i => i.Id.Equals(id));
        if (goldenBookInList != null)
        {
            goldenEditionBooks.Remove(goldenBookInList);
            Console.WriteLine("Remove successfully!");
        }
    }
    
    public void UpdateNormalBookById(int id)
    {
        try
        {
            Book bookInList = books.FirstOrDefault(i => i.Id.Equals(id));
            if (bookInList != null)
            {
                Console.Write("Enter Title: ");
                bookInList.Title = Console.ReadLine();
                Console.Write("Enter Author: ");
                bookInList.Author = Console.ReadLine();
                Console.Write("Enter price: ");
                bookInList.Price = Decimal.Parse(Console.ReadLine());
                Console.Write("Enter the Quantity: ");
                bookInList.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Update successfully!");
            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }

    }
    public void UpdateGoldenBookById(int id)
    {
        try
        {
            GoldenEditionBook godenBookInList = goldenEditionBooks.FirstOrDefault(i => i.Id.Equals(id));
            if (godenBookInList != null)
            {
                Console.Write("Enter Title: ");
                godenBookInList.Title = Console.ReadLine();
                Console.Write("Enter Author: ");
                godenBookInList.Author = Console.ReadLine();
                Console.Write("Enter the Price: ");
                godenBookInList.Price = Decimal.Parse(Console.ReadLine());
                Console.Write("Enter quantity: ");
                godenBookInList.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Update successfully!");
            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }

    }

    
}