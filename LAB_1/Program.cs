using System;

class Program
{
    /* ZADANIE 1 
     * static void Main(string[] args)
    {
        CalculateQuadraticRoots();
    }

    static void CalculateQuadraticRoots()
    {
        Console.WriteLine("Podaj współczynnik a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik c:");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Delta wynosi: {delta}");

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Pierwiastki to: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Jeden pierwiastek: x = {x}");
        }
        else
        {
            Console.WriteLine("Brak rzeczywistych pierwiastków.");
        }
    }
    */

    /*ZADANIE 2 
     * static void Main(string[] args)
     {
         Calculator();
     }

     static void Calculator()
     {
         while (true)
         {
             Console.WriteLine("Kalkulator - wybierz operację:");
             Console.WriteLine("1. Suma\n2. Różnica\n3. Iloczyn\n4. Iloraz\n5. Potęga\n6. Pierwiastek\n7. Sin\n8. Cos\n9. Tan\n0. Wyjście");
             int choice = Convert.ToInt32(Console.ReadLine());

             if (choice == 0)
                 break;

             if (choice >= 1 && choice <= 5)
             {
                 Console.WriteLine("Podaj pierwszą liczbę:");
                 double num1 = Convert.ToDouble(Console.ReadLine());

                 Console.WriteLine("Podaj drugą liczbę:");
                 double num2 = Convert.ToDouble(Console.ReadLine());

                 switch (choice)
                 {
                     case 1:
                         Console.WriteLine($"Wynik: {num1 + num2}");
                         break;
                     case 2:
                         Console.WriteLine($"Wynik: {num1 - num2}");
                         break;
                     case 3:
                         Console.WriteLine($"Wynik: {num1 * num2}");
                         break;
                     case 4:
                         if (num2 != 0)
                             Console.WriteLine($"Wynik: {num1 / num2}");
                         else
                             Console.WriteLine("Błąd: dzielenie przez zero");
                         break;
                     case 5:
                         Console.WriteLine($"Wynik: {Math.Pow(num1, num2)}");
                         break;
                 }
             }
             else if (choice == 6)
             {
                 Console.WriteLine("Podaj liczbę:");
                 double num = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine($"Pierwiastek wynosi: {Math.Sqrt(num)}");
             }
             else if (choice >= 7 && choice <= 9)
             {
                 Console.WriteLine("Podaj kąt w radianach:");
                 double angle = Convert.ToDouble(Console.ReadLine());

                 switch (choice)
                 {
                     case 7:
                         Console.WriteLine($"Sin: {Math.Sin(angle)}");
                         break;
                     case 8:
                         Console.WriteLine($"Cos: {Math.Cos(angle)}");
                         break;
                     case 9:
                         Console.WriteLine($"Tan: {Math.Tan(angle)}");
                         break;
                 }
             }
         }
     }
    */

    /*ZADANIE 3 
     * static void Main(string[] args)
     {
         ArrayOperations();
     }

     static void ArrayOperations()
     {
         double[] numbers = new double[10];

         Console.WriteLine("Podaj 10 liczb rzeczywistych:");
         for (int i = 0; i < 10; i++)
         {
             numbers[i] = Convert.ToDouble(Console.ReadLine());
         }

         while (true)
         {
             Console.WriteLine("Menu:\n1. Wyświetl od pierwszego do ostatniego\n2. Wyświetl od ostatniego do pierwszego\n3. Wyświetl elementy o nieparzystych indeksach\n4. Wyświetl elementy o parzystych indeksach\n0. Wyjście");
             int choice = Convert.ToInt32(Console.ReadLine());

             if (choice == 0)
                 break;

             switch (choice)
             {
                 case 1:
                     for (int i = 0; i < numbers.Length; i++)
                         Console.WriteLine(numbers[i]);
                     break;
                 case 2:
                     for (int i = numbers.Length - 1; i >= 0; i--)
                         Console.WriteLine(numbers[i]);
                     break;
                 case 3:
                     for (int i = 1; i < numbers.Length; i += 2)
                         Console.WriteLine(numbers[i]);
                     break;
                 case 4:
                     for (int i = 0; i < numbers.Length; i += 2)
                         Console.WriteLine(numbers[i]);
                     break;
             }
         }
     }

    */

    /* ZADANIE 4 
     * static void Main(string[] args)
     {
         ArrayCalculations();
     }

     static void ArrayCalculations()
     {
         double[] numbers = new double[10];

         Console.WriteLine("Podaj 10 liczb:");
         for (int i = 0; i < 10; i++)
         {
             numbers[i] = Convert.ToDouble(Console.ReadLine());
         }

         double sum = 0, product = 1, min = numbers[0], max = numbers[0];
         for (int i = 0; i < numbers.Length; i++)
         {
             sum += numbers[i];
             product *= numbers[i];
             if (numbers[i] < min) min = numbers[i];
             if (numbers[i] > max) max = numbers[i];
         }

         double average = sum / numbers.Length;

         Console.WriteLine($"Suma: {sum}");
         Console.WriteLine($"Iloczyn: {product}");
         Console.WriteLine($"Średnia: {average}");
         Console.WriteLine($"Minimalna wartość: {min}");
         Console.WriteLine($"Maksymalna wartość: {max}");
     }

     */


    /*Zadanie 5 
     * static void Main(string[] args)
    {
        for (int i = 20; i >= 0; i--)
        {
            if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                continue;

            Console.WriteLine(i);
        }
    }
    */

    /*
     * static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Podaj liczbę całkowitą:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
                break;

            Console.WriteLine($"Wprowadzona liczba: {number}");
        }
    }
    */


    /*Zadanie 7 
     * static void Main(string[] args)
    {
        BubbleSort();
    }

    static void BubbleSort()
    {
        Console.WriteLine("Podaj ilość liczb:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];

        Console.WriteLine("Podaj liczby:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Posortowane liczby:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
    */
}
