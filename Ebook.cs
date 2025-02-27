public class Ebook : Book {

    private static int fileSizeMB = -1;

    public static int FileSizeMB 
    {
        get { return Ebook.FileSizeMB; }
        set { Ebook.FileSizeMB = value; }
    }
    public Ebook (): base ("n/a","n/a",-1){}

    public override string ToString()
    {
        return $"Title {Title} by Author {Author} YearPublished: {YearPublished},File Size: {FileSizeMB}";
    }

}