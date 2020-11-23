using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsEx
{
    public class Execise
    {
        public void Ex6()
        {
            // Suma odwrotnośći
            double sum = 0.0;  
            
            // Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ + 1/3 + ¼ itd.
            for (int i = 1; i <= 20 ; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine($"Suma odwrotnośći wynosi: {sum}");
        }
        public void Ex5()
        {
            // Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i*i);
            }
        }

        public void Ex4()
        {
            // Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie
            int n = GetNumber();
            
            // liczba do wyświetlenia
            int number = 1;
            for (int i = 1; number <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (number > n) break;
                    Console.Write($"{number} ");
                    number++;
                }
                Console.WriteLine();  
            }
        }

        public int GetNumber()
        {
            int number = 0;
            string result = string.Empty;
            do
            {
                Console.Write("Podaj liczbę: ");
                result = Console.ReadLine();

            } while (!int.TryParse(result, out number) || number <= 0);
            return number;
        }

        public void Ex3()
        {
            // Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            // zakres pętli
            int n = 100;

            // zmienne do przechowywania element n-2 i n-1 
            long a = 0;
            long b = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.Write(b + ",");
                b = b + a;  // pod zmienną b przypisujemy następny wyraz ciągu
                a = b - a;  // pod zmienną a przypisujemy warość zmiennej b
            }
        }

        public void Recursive_Ex3()
        {
            int n = 20;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(fib(i) + ", ");
            }

        }

        public int fib(int n)
        {
            if (n <= 2) return 1;
            return fib(n - 2) + fib(n - 1);
        }

        public void Ex2()
        {
            // Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
            
            int n = 0, counter = 0;
            do
            {
                if (IsEven(n)) counter++;
                n++;
            } while (n <= 1000);
            
            Console.WriteLine($"\r\nW zakresie 0 do 1000 znajduje się {counter} liczb pierwszych. ");
        }

        public bool IsEven(int number)
        {
            if(number == 0) return false;

            if(number%2 != 0) return false;

            return true;
        }

        public void Ex1()
        {
            // Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
            int n = 100;
            int counter = 0;
         
            for(int i = 0; i<= n; i++)
            {
                if(isPrimeNumber(i))
                {
                    counter++;
                    Console.Write(i+", ");
                }
            }
            Console.WriteLine($"\r\nW zakresie 0 do {n} znajduje się {counter} liczb pierwszych. ");
        }

        public bool isPrimeNumber(int number)
        {
            // jeżeli liczba jest mniejsza niż 2 to nie jest liczbą pierwszą
            if (number < 2) return false;

            for(int i =2; i*i <= number; i++)
            {
                // jeżeli znajdziemy dzielnik to dana liczba nie jest liczbą pierwszą
                if(number % i == 0) return false;
            }

            return true;
        }
    }

}
