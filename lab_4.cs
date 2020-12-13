using System;
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
            // Lab_4

            B ObjectB4 = new B(7);
            Console.WriteLine("\nВывод первого массива с помощью индексатора:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(ObjectB4[i]);
            }
            Console.WriteLine("\nВывод второго массива с помощью индексатора:");
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(ObjectB4[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nРабота с классом С.");
            Console.WriteLine("Статическое поле без создания экземпляра: " + C<int>.s);
            C<int> ObjectC1 = new C<int>();
            ObjectC1.FieldT = 12;
            Console.WriteLine("Первый тип Т класса С: " + ObjectC1.FieldT.GetType());
            C<string> ObjectC2 = new C<string>();
            ObjectC2.FieldT = "string";
            Console.WriteLine("Воторой тип Т класса С: " + ObjectC2.FieldT.GetType());


            Console.ReadLine();


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
        private int[,] arr2 = {{2, 3}, {5, 1}, {7, 1}}; //4. второй массив создала двумерный, 
                                        //т.к. нельзя два индексатора с одинаковым набором параметров 

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

        //4. индексатор для первого массива
        public float this[int index]
        {
            get { return arr[index]; }
        }

        //4. индексатор для второго массива 
        public int this[int index1, int index2]
        {
            get { return arr2[index1,index2]; }
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

    //Lab_4
    class C<T>
    {
        public static string s = "static field";
        private T fieldT;

        //свойтсво поля fieldT
        public T FieldT
        {
            get { return fieldT; }
            set { fieldT = value; }
        }
    }
}