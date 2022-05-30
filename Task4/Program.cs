using System;
using Task2;
using System.Collections.Generic;

//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Создайте расширяющий метод: public static T[] GetArray(this MyList list) 
//Примените расширяющий метод к экземпляру типа MyList, разработанному в домашнем задании 2 для данного урока. 
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). Задание 5 Зайдите на сайт MSDN. 
//Используя поисковые механизмы MSDN, найдите самостоятельно описание темы по каждому примеру, 
//который был рассмотрен на уроке, так, как это представлено ниже, в разделе «Рекомендуемые ресурсы», 
//описания данного урока. Сохраните ссылки и дайте им короткое описание.
namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            var mlInt = new MyList<int>();
            var mlString = new MyList<string>();

            mlInt.Add(1);
            mlInt.Add(10);

            mlString.Add("2");
            mlString.Add("20");

            Console.WriteLine(mlInt);
            Console.WriteLine(mlString);
            Console.WriteLine(mlInt.GetArray());
            Console.WriteLine(mlString.GetArray());

            //Delay
            Console.ReadKey();
        }

    }
    static class ExtensionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
                result[i] = list[i];
            return result;
        }
    }

}
