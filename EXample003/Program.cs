// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
class ProgramNewArray2 {
  public static void Main (string[] array) {
    
            double[] GenerateRandomArray(int size, int start, int end)
            {
                
                double[] RandomArray = new double[size];
                Random rand = new Random();
                for (int i = 0; i < RandomArray.Length; i++)
                {
                   
                    RandomArray[i] = new Random().Next(start, end + 1); 
                }            
                return RandomArray;
            }

            
            void ShowArray(double[] Array)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    Console.WriteLine(Convert.ToString(Array[i]));
                }
            }

            double FindingTheMaxAndMin(double[] Array1)
            {                   
                double maxNum = Array1[0];
                double minNum = Array1[0];   
                for (int i = 1; i < Array1.Length; i++)
                    if(maxNum < Array1[i]) 
                    {
                        maxNum = Array1[i];
                    }    
                for (int i = 1; i < Array1.Length; i++)   
                    if (minNum > Array1[i])
                    {
                        minNum = Array1[i];
                    }
                    double difference = maxNum - minNum;
                    return difference;
            }
            
            double[] myArray = new double[10];
            myArray = GenerateRandomArray(10, 1, 100);
            ShowArray(myArray);
            Console.WriteLine("Разница между минимальным и максимальным элементами массива: "  + FindingTheMaxAndMin(myArray));
  }
}