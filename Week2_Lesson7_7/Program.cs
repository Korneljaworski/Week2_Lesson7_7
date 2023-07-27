public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
            Dane testowe:
            25
            63
            79
            Rezultat w terminalu :
            79 jest największa z podanych
        */

        Console.WriteLine("Podaj pierwszą liczbę:");
        int userNumber1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        int userNumber2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj trzecią liczbę:");
        int userNumber3 = Int32.Parse(Console.ReadLine());

        if (userNumber1 >= userNumber2 && userNumber1 >= userNumber3)
        {
            Console.WriteLine($"{userNumber1} jest największa z podanych");
        }
        else if (userNumber2 >= userNumber1 && userNumber2 >= userNumber3)
        {
            Console.WriteLine($"{userNumber2} jest największa z podanych");
        }
        else if (userNumber3 >= userNumber1 && userNumber3 >= userNumber2)
        {
            Console.WriteLine($"{userNumber3} jest największa z podanych");
        }
    }

}
