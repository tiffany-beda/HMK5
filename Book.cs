public class Book
{
    private string title = "n/a";
    private string author = "n/a";
    
    private int yearPublished = -1;

    public string Title 
    {
        get {return this.title;}
        set {this.title = value;}
    }
    public string Author 
    {
        get {return this.author; }
        set {this.author = value; }
    }
    public int YearPublished 
    {
        get {return this.yearPublished;}
        set {this.yearPublished = value;}
    }

    public Book (): this ("n/a","n/a",-1){}
    public Book (string _title,string _author,int _yearPublished)
    {
        this.Title = _title;
        this.Author = _author;
        this.YearPublished = _yearPublished;
    }
    public override string ToString()
    {
        return $" Title {Title} by Author {Author} YearPublished {YearPublished} ";
    }
}