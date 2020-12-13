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
            // Lab_5

            B objectB1 = new B();
            objectB1.K = 8;
            Console.WriteLine("Первый пример, где К = 8.");
            if (objectB1)
            {
                Console.WriteLine("Переменная К больше нуля");
            } 
            else
            {
                Console.WriteLine("Переменная К меньше или равна нулю");
            }

            B objectB2 = new B();
            objectB2.K = -4;
            Console.WriteLine("\nВторой пример, где К = -4.");
            if (objectB2)
            {
                Console.WriteLine("Переменная К больше нуля");
            }
            else
            {
                Console.WriteLine("Переменная К меньше или равна нулю");
            }

            Console.WriteLine("\nОператор & определяет равенство полей К у двух экземпляров класса В.");
            Console.WriteLine("K= 8 и K = -4: " + (objectB1 & objectB2));
            objectB2.K = 8;
            Console.WriteLine("K= 8 и K = 8: " + (objectB1 & objectB2));


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
        private int k; //поле для 5 лаб и его свой-ство ниже

        public int K
        {
            get { return k; }
            set { k = value; }
        }

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

        //5 
        public static bool operator false(B obj)
        {
            if (obj.k <= 0)
                return true;
            return false;
        }

        
        public static bool operator true(B obj)
        {
            if (obj.k > 0)
                return true;
            return false;
        }

        public static bool operator &(B obj1, B obj2)
        {
            if (obj1.k == obj2.k)
                return true;
            return false;
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