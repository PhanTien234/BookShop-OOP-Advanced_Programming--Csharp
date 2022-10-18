namespace BookShop;

public class Book : IInformation
{
    private int id;
    private string title;
    private string author;
    private decimal price;
    private int quantity;


    public Book(int id, string title, string author, decimal price, int quantity)
    {
        this.Id = id;
        this.Title = title;
        this.Author = author;
        this.Price = price;
        this.Quantity = quantity;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Title
    {
        get => title;
        set => title = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Author
    {
        get => author;
        set => author = value ?? throw new ArgumentNullException(nameof(value));
    }

    public virtual decimal Price
    {
        get => price;
        set => price = value;
    }

    public int Quantity
    {
        get => quantity;
        set => quantity = value;
    }

    public string PrintInformation()
    {
        return $"|{GetType()} \t| ID: {Id} | Title: {Title} | Author: {Author} | Price : {Price:f2} | Quantity: {Quantity}     |\n";
    }

}