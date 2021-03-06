﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab_2

            A ObjectA = new A();
            Console.WriteLine("a/b= " + ObjectA.c + "\n—-b = " + ObjectA.c1 + "\na*b= " + ObjectA.c2);

            B ObjectB1 = new B();
            Console.WriteLine("\nсвойство первого экземпляра класса В: f = " + ObjectB1.f);

            B ObjectB2 = new B(2.4f);
            Console.WriteLine("\nсвойство второго экземпляра класса В: f = " + ObjectB2.f);
          


        }
    }
    class A
    {
        private float a, b;

        public A()
        {
            a = 1.7f;
            b = 4.2f;
        }

        public float c
        {
            get { return a /= b; }
        }
        public float c1
        {
            get { return --b; }
        }
        public float c2
        {
            get { return a * b; }
        }
    }

    class B : A
    {
        private float d;
        private float[] arr;

        //назвала f, так как уже есть св-во с2 в классе А
        public float f
        {
            get
            {
                switch (d)
                {
                    //выражения со свойства с и с2, т.к. a,b -приватные поля класса А и не доступны в классе наследнике
                    case 1: return d /= c;
                    default: return d * c2;
                }
            }
        }

        public B() : base()
        {
            d = 1f;
        }

        public B(float d)
        {
            this.d = d;
        }

        //конструктор для создания массива 
        public B(int lenght)
        {
            d = 1f;
            arr = new float[lenght];

            for (int i = 0; i < lenght; i++)
            {
                arr[i] = i * f;
            }
        }  
        
        //метод для вывода массива
        public void GetArr()
        {
            Console.WriteLine("Массив: ");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

    }
}