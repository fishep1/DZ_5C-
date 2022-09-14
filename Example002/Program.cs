//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

class ProgramNewArray //Создание класса 
{
    public static void Main (string[] array1) 
    {
        int[] GenerateRandomArray(int size, int num1, int numEnd) // Метод для создания случайного массива размером size, в диапозоне от num1 до numEnd
        {
            int[] RandomArray = new int[size]; // Создаем массив "RandomArray" и выделяем для него {size} памяти
            for (int i = 0; i < size; i++)
            {
                RandomArray[i] = new Random().Next(num1,numEnd +1); // генерируем число из диапозона num1, numEnd и записываем его в [i] - элемент массива
            }
            return RandomArray;
        }

        void ShowArray(int[] Array1) // Метод вывода значений элемментов массива на экран
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    Console.WriteLine(Convert.ToString(Array1[i]));
                }
            }
            // Сумма всех нечетных элементов массива 
            int SumOfOddNumbers(int[] Array2)
            {    
                int sum = 0;
                for (int i = 0; i < Array2.Length; i++)
                    if (i % 2 == 1)
                    {
                        sum += Array2[i];
                    }
                return sum;
            }
            // ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ
            int[] myArray = new int[4];
            myArray = GenerateRandomArray(4, 10, 99);
            ShowArray(myArray);
            Console.WriteLine("Сумма элементов состоящих на нечетных позяциях массива: " + SumOfOddNumbers(myArray));
    }
}