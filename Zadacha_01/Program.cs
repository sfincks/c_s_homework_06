//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] insertNumber()
{
    System.Console.WriteLine("Введите числа через пробел");
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return array;
}

int positiveCount(int[] array)
{
    int countPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            countPositive++;
        }
    }
    return countPositive;
}


int[] arr = insertNumber();
//System.Console.WriteLine("["+string.Join(", ",arr)+"]");
System.Console.WriteLine(positiveCount(arr));