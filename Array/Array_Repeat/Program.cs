using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            // расположим в обратном порядке
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.Write($"{number} \t");
            }

            // уменьшим массив до 4 элементов
            Array.Resize(ref numbers, 4);

            foreach (int number in numbers)
            {
                Console.Write($"{number} \t");
            }

            Console.WriteLine("\n");

            int[] nature = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int[] getCopy = new int[5];

            // копируем из numbers с 2-го индекса 5 элементов 
            // и поместим их в массив numbers2, начиная с 0-го индекса
             Array.Copy(nature, 2, getCopy, 0, 5);

            foreach (int number in getCopy)
            {
                Console.Write($"{number} \t");
            }


            Console.WriteLine("\n");

            int[] naturee = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            Array.Clear(naturee,0,4);

            foreach (int number in naturee)
            {
                Console.Write($"{number} \t");
            }

            Console.ReadLine();
        }
        ///<summary>
        ///Length 
        ///Rank
        ///BinarySearch()
        ///Clear()
        ///Copy()
        ///Exist()
        ///Find()
        ///FindAll()
        ///IndexOf()
        ///Resize(ref array,numberofLength)
        ///Reverse()
        ///Sort()
        ///Все массивы в C# построены на основе класса Array из пространства имен System. Этот класс определяет ряд свойств 
        ///и методов, которые мы можем использовать при работе с массивами. Основные свойства и методы:

        ///Свойство Length возвращает длину массива

        ///Свойство Rank возвращает размерность массива

        ///Статический метод BinarySearch() выполняет бинарный поиск в отсортированном массиве

        ///Статический метод Clear() очищает массив, устанавливая для всех его элементов значение по умолчанию

        ///Статический метод Copy() копирует часть одного массива в другой массив

        ///Статический метод Exists() проверяет, содержит ли массив определенный элемент

        ///Статический метод Find() находит элемент, который удовлеворяет определенному условию

        ///Статический метод FindAll() находит все элементы, которые удовлеворяет определенному условию

        ///Статический метод IndexOf() возвращает индекс элемента

        ///Статический метод Resize() изменяет размер одномерного массива

        ///Статический метод Reverse() располагает элементы массива в обратном порядке

        ///Статический метод Sort() сортирует элементы одномерного массива
        ///
        //////Разберем самые используемые методы.Например, изменим порядок элементов и размер массива:

        ///</summary>
    }
}
