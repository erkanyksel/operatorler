internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******   atama ve işlemli atama Operatorler ******");

        int x = 5;
        int y = 3;

        y = y + 2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);

        y /= 2;
        Console.WriteLine(y);


        x *= 2;
        Console.WriteLine(x);

        Console.WriteLine("******   Mantıksal Operatorler ******");

        //  mantıksal operatorler

        bool isSuccess = true;
        bool isCompleted = false;

        if (isCompleted && isSuccess)
            Console.WriteLine("Perfect");


        if (isCompleted || isSuccess)
            Console.WriteLine("Great");

        if (!isCompleted && isSuccess)
            Console.WriteLine("Fine");

        Console.WriteLine("******   Ilıskisel Operatorler ******");


        // İlişkisel operatorler
        // > <  <=

        int a = 3;
        int b = 4;

        bool sonuc = a < b;

        Console.WriteLine(sonuc);
        sonuc = a > b;
        Console.WriteLine(sonuc);
        sonuc = a >= b;
        Console.WriteLine(sonuc);
        sonuc = a <= b;
        Console.WriteLine(sonuc);
        sonuc = a == b;
        Console.WriteLine(sonuc);
        sonuc = a != b;
        Console.WriteLine(sonuc);


        Console.WriteLine("******   Aritmetik  Operatorler ******");


        // Aritmetik operatorler
        // / + - *

        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = ++sayi1;
        Console.WriteLine(sonuc1);

        //  %  mod alır
        int sonuc2 = 20 % 3;
        Console.WriteLine(sonuc2);


    }
}