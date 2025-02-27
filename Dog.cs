public class Dog: Animal 
{
    public override string MakeSound()
    {
        return "Bark";
    }
    public override string ToString()
    {
        return $"{MakeSound()}";
    }
}