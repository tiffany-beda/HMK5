public class Cat: Animal 
{
    public override string MakeSound()
    {
        return "Meow";
    }
    public override string ToString()
    {
        return $"{MakeSound()}";
    }
}