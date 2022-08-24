namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Программа из имеющегося массива формирует массив из строк, длина которых меньше либо равна 3 символа.");
            Console.WriteLine();
            Console.Write("Введите ограниечение длинны символов для поверки (по заданию равно - 3) - ");
            int lengthElementArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            string[] arrStr = new string[] { };
            string? str = "";
            
            while (str.ToLower() != "1" && str.ToLower() != "2")
            {
                Console.Write(
                    "Ввести массив вручную - 1, \n"
                        + "использовать массив для примера [1234, 1567, -2, computer science] - 2: "
                );
                str = Console.ReadLine();
            }
            
            if (str.ToLower() == "1")
            {
                Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                arrStr = new string[n];
                for (int i = 0; i < arrStr.Length; i++)
                {
                    Console.Write($"Введите элемент массива {i + 1}: ");
                    arrStr[i] = Console.ReadLine();
                }
            }
            else
            {
                arrStr = new string[] { "1234", "1567", "-2", "computer science" };
            }

            int num = CheckArr(arrStr, lengthElementArray);
            string[] newArrayStr = new string[num];
            FillNewArray(arrStr, newArrayStr, lengthElementArray);
            Console.WriteLine();
            Console.WriteLine("Полученный массив: ");
            PrintArray(newArrayStr);

            static void PrintArray(string[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"| {arr[i]} |");
                }
            }

            int CheckArr(string[] array, int lengthElementArray)
            {
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <= lengthElementArray)
                        result++;
                }
                return result;
            }

            static void FillNewArray(string[] Array, string[] newArray, int lengthElementArray)
            {
                int j = 0;
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i].Length <= lengthElementArray)
                    {
                        newArray[j] = Array[i];
                        j++;
                    }
                }
            }
        }
    }
}
