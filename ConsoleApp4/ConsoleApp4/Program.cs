static void Main()
{
    using System
class Program
{
    static void Main(string[] args)
    {
class ClassCounter Counter = new ClassCounter();
    Handler_I Handler1 = new Handler_I();
    Handler_II Handler2 = new Handler_II();
{
Counter.onCount += Handler1.Message;
Counter.onCount += Handler2.Message;
Counter.Count();
}
}
}
}
{
public delegate void SchetchikContainer();
public event SchetchikContainer onCount;
public void Count()
{
    for (int i = 0; i < 100; i++)
    {
        if (i == 77)
        {
            if (onCount != null)
            {
                onCount();
            }
        }
    }
}
class Handler_I
{
    public void Message()
}
Console.WriteLine("Пора действовать, ведь уже 77")
}
}
class Handler_II
{
    public void Message()
}
Console.WriteLine("ТУже 77, Давно пора было начать!")
}
}


    
