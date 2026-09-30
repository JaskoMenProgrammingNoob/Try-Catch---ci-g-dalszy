using System.IO;
class Program
{
     

    static void Main(string[] args)
    {
        double a = 0;
        double b = 0;
        double c = 0;
        double wynik = 0;
        double x1 = 0;
        double x2 = 0;
        double x0 = 0;
        FileStream F, F1;
        F = new FileStream("wynik.txt", FileMode.Create);
        StreamWriter zapis = new StreamWriter(F);
        try
        {
            a = double.Parse(args[0]);
            b = double.Parse(args[1]);
            c = double.Parse(args[2]);
            if (double.Parse(args[0]) == 0)
            {
                zapis.WriteLine("A = 0, to funkcja liniowa!" );
                Console.WriteLine("A = 0, to funkcja liniowa!");
                zapis.Close();
                return;
            }

        } catch (Exception)
        {
            
            Console.WriteLine("Wprowadzono niepoprawne liczby! ");
            
            return;
        }
        Console.WriteLine("Wprowadzono następujące wartości: a = {0}, b = {1}, c = {2}", args);
        Console.Write("Obliczam równanie: ");
        wynik = double.Parse(args[1]) * double.Parse(args[1]) - 4 * double.Parse(args[0]) * double.Parse(args[2]);
        if ( wynik < 0)
        {
            Console.WriteLine("Delta mniejsza od zera - brak rozwiązań.");
        } else if (wynik == 0)
        {
            Console.Write("Delta = 0, obliczam jedno miejsce zerowe: ");
            x0 = (-double.Parse(args[1]) / 2 * double.Parse(args[0]));
            zapis.WriteLine($"X0: {x0}");
            Console.WriteLine($"X0: {x0}");
        } else
        {
            Console.Write("Delta > 0, obliczam dwa miejsca zerowe: ");
            x1 = (-double.Parse(args[1]) - Math.Sqrt(wynik) / 2 * double.Parse(args[0]));
            x2 = (-double.Parse(args[1]) + Math.Sqrt(wynik) / 2 * double.Parse(args[0]));
            zapis.WriteLine($"X1: {x1}");
            zapis.WriteLine($"X2: {x2}");
            Console.WriteLine($"X1: {x1}");
            Console.WriteLine($"X2: {x2}");
        }    
        //Console.Write(int.Parse(args[1]) * int.Parse(args[1]) - 4 * int.Parse(args[0]) * int.Parse(args[2]));
        //zapis.WriteLine(int.Parse(args[1]) * int.Parse(args[1]) - 4 * int.Parse(args[0]) * int.Parse(args[2]));    
        zapis.Close();
        F.Close();
    }
}
        
