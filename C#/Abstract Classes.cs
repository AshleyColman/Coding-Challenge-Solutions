

//Write MyBook class
class MyBook : Book
{
    private int price;

    public MyBook(string _title, string _author, int _price) : base(_title, _author)
    {
        price = _price;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}
