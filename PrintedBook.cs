public class PrintedBook : Book 
{

    private static int pageCount = -1;

    public static int PageCount 
    {
        get { return PrintedBook.pageCount; }
        set { PrintedBook.pageCount = value; }
    }
    public PrintedBook (): base ("n/a","n/a",-1){}

    public override string ToString()
    {
        return $"Title {Title} by Author {Author} YearPublished: {YearPublished},Number of pages: {PageCount}";
    }

}