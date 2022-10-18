namespace BookShop;

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
        Console.WriteLine("__________________________");
        Console.WriteLine(" _____________________________________* * *List of Golden Book* * *______________________________________");
        for (int i = 0; i < goldenEditionBooks.Count; i++)
        {
            Console.Write(goldenEditionBooks[i].PrintInformation());
        }
        Console.WriteLine("|__________________________________________________END___________________________________________________|");
    }

    
}