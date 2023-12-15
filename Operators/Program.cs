﻿using System.Runtime.CompilerServices;

namespace operatorler;

class Program
{
    static void Main(string[] args)
    {
        // Atama ve İşlemli Atama (=, +=, -=, *=, /=)
        Console.WriteLine("***** Atama ve İşlemli Atama *****");
        
        int x = 3;
        int y = 3;
        
        y = y + 2;
        Console.WriteLine(y);
        
        y += 2;
        Console.WriteLine(y);
        
        y -= 2;
        Console.WriteLine(y);
        
        y /= 1;
        Console.WriteLine(y);
        
        x *= 2;
        Console.WriteLine(x);

        //Mantıksal Operatorler (||, &&, !)
        Console.WriteLine("***** Mantiksal Operatorler *****");

        bool isSuccess = true;
        bool isCompleted = false;

        if(isSuccess && isCompleted)
            Console.WriteLine("Perfect!");
        
        if(isSuccess || isCompleted)
            Console.WriteLine("Great!");
        
        if(isSuccess && !isCompleted)
            Console.WriteLine("Fine!");

        // Iliskisel Operatorler (==,!=, <, >, >=,<=)
        Console.WriteLine("***** Iliskisel Operatorler *****");

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
        
        // Aritmetik Operatorler (+, -, *, /, %, ++, --)
        Console.WriteLine("***** Aritmetik Operatorler *****");

        int sayi1 = 10;
        int sayi2 = 3;
        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine(sonuc1);
        
        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);
        
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        
        sonuc1 = sayi1 - sayi2;
        Console.WriteLine(sonuc1);
        
        sonuc1 = sayi1++;
        Console.WriteLine(sonuc1);
        
        sonuc1 = sayi1--;
        Console.WriteLine(sonuc1);
        
        sonuc1 = sayi1 % sayi2;
        Console.WriteLine(sonuc1);
    }
}
