using System;

public class MainClass
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("Запустить диагностику");
                break;

            case 2:
                Console.WriteLine("Вылечить поврежденные блоки системы");
                break;

            case 'e':
                Console.WriteLine("Перезапустить пункт управления");
                break;

        }
    }
}
