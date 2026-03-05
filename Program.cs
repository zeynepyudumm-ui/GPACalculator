using System;

class Program
{
    static void Main()
    {
        double totalWeighted = 0;
        int totalCredits = 0;

        Console.Write("Kaç ders gireceksiniz? ");
        int courseCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < courseCount; i++)
        {
            Console.WriteLine("\n" + (i + 1) + ". Ders");

            Console.Write("Kredi: ");
            int credit = int.Parse(Console.ReadLine());

            Console.Write("Not katsayısı: ");
            double grade = double.Parse(Console.ReadLine());

            double weighted = credit * grade;

            Console.WriteLine("Hesaplanan: " + weighted);

            totalWeighted += weighted;
            totalCredits += credit;
        }

        double gpa = totalWeighted / totalCredits;

        Console.WriteLine("\nToplam Ağırlıklı: " + totalWeighted);
        Console.WriteLine("Toplam Kredi: " + totalCredits);
        Console.WriteLine("Dönem Ortalaması: " + gpa);

    }
}
