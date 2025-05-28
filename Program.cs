using System;
class Program
{
    static void Main()
    {
        System.Console.WriteLine("bir cümle yaz");
        string cümle = Console.ReadLine();

        string[] kelimeler = cümle.Split(new char[] { ' ' });
        System.Console.WriteLine("Kelime Sayısı:");
        System.Console.WriteLine(kelimeler.Length);

        int harfs = 0;
        foreach (var harf in cümle)
        {
            if (char.IsLetter(harf))
            {
                harfs++;
            }
        }
          Console.WriteLine("Harf Sayısı:");
          Console.WriteLine(harfs);
    }
}