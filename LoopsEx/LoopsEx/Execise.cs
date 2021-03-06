﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsEx
{
    public class Execise
    {
        public void Ex10()
        {
            // Pobiernaie danych
            int a = GetNum();
            int b = GetNum();

            int nwd = NWD(a, b);
            int nww = NWW(a, b, nwd);

            Console.WriteLine($"Największy wspólny dzielnik (NWD) liczb {a} i {b} wynosi: {nwd}");
            Console.WriteLine($"Najmniejsza wspólna wielokrotność (NWW) liczb {a} i {b} wynosi: {nww}");
        }

        private static int GetNum()
        {
            // liczba musi być całkowita i  dodatania;
            int temp = 0;
            string input = string.Empty;

            do
            {
                Console.Write("Podaj liczbę:");
                input = Console.ReadLine();
                int.TryParse(input, out temp);
            } while (temp <= 0);

            return temp;
        }

        private int NWW(int a, int b, int nwd)
        {
            return (a * b) / nwd;
        }

        private int NWD(int a, int b)
        {
            int temp;

            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public void Ex9()
        {
            // Napisz program, który zamieni liczbę dziesiętną na liczbę binarną
            // wartość testowa
            int decimalNumber = 57;
            int number = decimalNumber;
            string binNum = string.Empty;

            do
            {               
                if (number % 2 == 0) binNum += 0;
                else binNum += 1;
                number /= 2;

            } while (number >  0) ;

            Console.WriteLine($"Liczba {decimalNumber} w systemie dziesiętnym to {Reverse(binNum)} w systemie binarnym");
        }

        public string Reverse(string value)
        {
            string result = string.Empty;

            for (int i = value.Length-1 ; i >= 0; i--)
            {
                result += value[i];
            }
            return result;
        }

        public void Ex8()
        {
            // Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków
            Console.Write("Podaj wyraz: ");
            string statement = Console.ReadLine();
            string reverseStatement = string.Empty;

            for (int i = statement.Length-1; i >= 0; i--)
            {
                reverseStatement += statement[i];
            }

            Console.WriteLine("Odwrócony wyraz: " + reverseStatement);
        }

        public void Ex7()
        {
            // Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
            int len = 0;
            string value = string.Empty;
            do
            {
                Console.Write("Podaj długość przekątnej figury (liczba całkowita, nieparzysta): ");
                value = Console.ReadLine();
                int.TryParse(value, out len);
            } while (len <= 1 || len % 2 == 0 );

            // Przekątna diamentu 
            int diagonal = len / 2;

            for (int i = diagonal; i >0 ; i--)
            {
                for (int j = i; j > 0 ; j--)
                {
                    Console.Write(" ");
                }
                int cond = 2 * (diagonal - i) + 1;
                for (int k = cond; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            for (int i = 0; i <= diagonal; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                int cond = 2 * (diagonal - i) + 1;

                for (int k = cond; k > 0 ; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

       
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
