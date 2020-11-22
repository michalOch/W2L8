﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsEx
{
    public class Execise
    {
        public void Ex3()
        {
            // Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
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
