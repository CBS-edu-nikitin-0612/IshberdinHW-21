using System;

//Используя Visual Studio, создайте проект по шаблону Console Application. Создайте класс MyList. 
//Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List. 
//Минимально требуемый интерфейс взаимодействия с экземпляром, 
//должен включать метод добавления элемента, 
//индексатор для получения значения элемента по указанному индексу и 
//свойство только для чтения для получения общего количества элементов.

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            var ml = new MyList<int>();
            int i = 0;

            ml.Add(1);
            ml.Add(2);

            while (i < ml.Count)
            {
                Console.WriteLine(ml[i]);
                i++;
            }

            //Delay
            Console.ReadKey();
        }
    }
    public class MyList<T>
    {
        private int count = 0;
        private T[] elements;

        public T this[int index] { get { return elements[index]; } set { elements[index] = value; } }

        public int Count { get { return count; } }

        public void Add(T item)
        {
            T[] tempElements = new T[this.Count + 1];
            for (int i = 0; i < this.Count; i++)
            {
                tempElements[i] = elements[i];
            }
            count++;
            tempElements[count - 1] = item;
            elements = tempElements;
        }
        public MyList()
        {
            this.count = 0;
            this.elements = new T[this.Count];
        }
    }
}
