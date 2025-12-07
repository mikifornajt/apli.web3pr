namespace cw4_class;

public class Oceny
{
    private int[] oceny;
    private int ile;

    public Oceny(int maxOcen)
    {
        oceny = new int[maxOcen];
        ile = 0;
    }

    public void DodajOcene(int ocena)
    {
        if (ocena < 1 || ocena > 6)
        {
            Console.WriteLine("Błąd! Ocena musi być od 1 do 6");
            return;
        }

        if (ile < oceny.Length)
        {
            oceny[ile] = ocena;
            ile++;
            Console.WriteLine($"Dodano ocenę: {ocena}");
        }
        else
        {
            Console.WriteLine("Tablica pełna!");
        }
    }

    public void PokazOceny()
    {
        Console.Write("Twoje oceny: ");
        for (int i = 0; i < ile; i++)
        {
            Console.Write(oceny[i] + " ");
        }
        Console.WriteLine();
    }

    public double Srednia()
    {
        if (ile == 0)
            return 0;

        int suma = 0;
        for (int i = 0; i < ile; i++)
        {
            suma += oceny[i];
        }
        return (double)suma / ile;
    }

    public int Najlepsza()
    {
        if (ile == 0)
            return 0;

        int max = oceny[0];
        for (int i = 1; i < ile; i++)
        {
            if (oceny[i] > max)
                max = oceny[i];
        }
        return max;
    }

    public int Najgorsza()
    {
        if (ile == 0)
            return 0;

        int min = oceny[0];
        for (int i = 1; i < ile; i++)
        {
            if (oceny[i] < min)
                min = oceny[i];
        }
        return min;
    }

    public override string ToString()
    {
        return $"Ilość ocen: {ile}, Średnia: {Srednia():F2}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("============================");
        Console.WriteLine("   MENEDŻER OCEN UCZNIA");
        Console.WriteLine("============================\n");

        Oceny mojeOceny = new Oceny(10);

        while (true)
        {
            Console.WriteLine("\n1. Dodaj ocenę");
            Console.WriteLine("2. Pokaż wszystkie oceny");
            Console.WriteLine("3. Pokaż statystyki");
            Console.WriteLine("4. Wyjdź");
            Console.Write("\nWybierz opcję: ");

            string wybor = Console.ReadLine();

            if (wybor == "1")
            {
                Console.Write("Podaj ocenę (1-6): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int ocena))
                {
                    mojeOceny.DodajOcene(ocena);
                }
                else
                {
                    Console.WriteLine("Niepoprawna wartość!");
                }
            }
            else if (wybor == "2")
            {
                mojeOceny.PokazOceny();
            }
            else if (wybor == "3")
            {
                Console.WriteLine("\n--- STATYSTYKI ---");
                Console.WriteLine(mojeOceny.ToString());
                Console.WriteLine($"Najlepsza ocena: {mojeOceny.Najlepsza()}");
                Console.WriteLine($"Najgorsza ocena: {mojeOceny.Najgorsza()}");
            }
            else if (wybor == "4")
            {
                Console.WriteLine("\nDo zobaczenia!");
                break;
            }
            else
            {
                Console.WriteLine("Niepoprawna opcja!");
            }
        }
    }
}