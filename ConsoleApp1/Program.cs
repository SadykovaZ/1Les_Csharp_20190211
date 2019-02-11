using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int p = 89;
        static void Main(string[] args)
        {
            //int x = 55;
            ////int x2 = new int();

            //object x3 = "";

            //var test = 56; /*это тип определяется во время исполнения и не должна быть нулем, но в результате может поместиться ноль*/

            //Console.WriteLine("Test");
            //string name = Console.ReadLine();
            ///*write в одну строку, writline - новая строка */
            //Console.WriteLine("Hello" + name);

            //int x = 56;
            //short s = (short)x;
            ////short s = x as short;
            ////1 метод преоюразования
            //string number = "test";
            //short s1  = short.Parse(number);
            //// short s1 = short.Parse(x.ToString()); /*применимо ко всему и только у string есть*/

            ////2 метод преобразования
            //s = 0;
            //int u = 56;
            //short.TryParse(number, out s);
            //if (short.TryParse(u.ToString(), out s))
            //{

            //    Console.WriteLine("OK");
            //}

            ////3 метод преобразования
            //int c = Convert.ToInt32(u);


            //double o = 56.5;
            //double y = o + u;

          //  Task1();
            int x1 = 5;
            int x2 = 6;

            int x3=96;
            int x4 = 6;

            Console.WriteLine("x1 = {0}, x2 ={1}", x1,x2);
            swap(ref x1, ref x2, out x3, out x4);

            Console.WriteLine("x1 = {0}, x2 ={1}", x1, x2);

          //  string[] arr = new string[200];
            string[] arr1 = { "5", "4", "6" };
           // arr[25] = "";

            Console.WriteLine(arr1.Length);

            Array.Reverse(arr1);
            for (int i = 0; i < 2; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine(arr1);
            var result = arr1.OrderBy(o => o);


            int ll = 5;
            int lp = 8;
            int[,] arr2 = new int[ll, lp];

            for (int i = 0; i < ll; i++)
            {
                for (int j = 0; j < lp; j++)
                {


                }
            }

        }

        static void Task1()
        {
            //1.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            Console.WriteLine("5 6 8");

            //2.	Вывести на экран числа 5, 10 и 21 одно под другим.
            Console.WriteLine("5\n6\n8");

            //3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.

            Console.WriteLine("Введите расстояние в санитметрах");
            double cm = 0;

            double.TryParse(Console.ReadLine(), out cm);

            double result = cm / 100;
            Console.WriteLine("Result {0} ({0}) cfds{1}", result,cm);

            //6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            //  a.А или В;
            //  b.А и В;
            //  c.В или С.

            bool A = true;
            bool B = false;
            bool C = false;

            if(A||B)
            {
                Console.WriteLine("A OR B");
            }

            if (A & B)
            {
                Console.WriteLine("A AND B");
            }

            if(B||C)
            {
                Console.WriteLine("B or C");
            }
                       
        }

        //19.	Напишите функцию swap(int* a, int* b), которая изменяет значения параметров a и b так, что новое значение a рав- но старому значению b и наоборот.

        static bool swap(ref int a, ref int b, out int x, out int x2)
        {
            int temp = a;
            a = b;
            b = temp;
            x = 0;
            x2 = 0;
            return true;
        }

        //31.	Напишите функцию int f(int N, int n), которая вычисляет и возвращает наименьшее из чисел, больших или равных N, которое делится нацело на n. Используйте оператор while.
        static int f(int x, int n)
        {
            
            while (true)
            {
                if (x % n == 0)
                { return x; }


            }      

            return 0;
        }
    }

    class A
    {

    }
}
