namespace BookShop;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(int id, string title, string author, decimal price, int quantity) :
        base(id, title, author, price, quantity)
    {
    }
    
}