// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


void start()
{
    int[] arr = new int[0];
    arr = NewArray(arr);
    int result = PositiveNumber(arr);
    Console.WriteLine($"положительных цифр в вашем массиве = {result}");
}


int [] NewArray(int [] arr)
{
    int count = 0;
    while(true)
    {
        Console.WriteLine("Чтобы ввести число в массив нажмите 1.  Для вывода массива любое другое.");
        if (Console.ReadLine() == "1")
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[count] = revisor();
            count ++;
        }
        else
        {
            Console.WriteLine("Ваш созданный массив");
            string joinArr = string.Join(", ", arr);
            Console.WriteLine(joinArr);
            return arr;
            
        }
    }
}


int revisor()
{ 
    int number;
    


    while(true)
    {
        Console.WriteLine("Введите число:");
        string s1 = Console.ReadLine();
        if (int.TryParse(s1, out number))
        {
            return number;  
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Это не число!");
        }
    }
}

int PositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count ++;
        }
    }
    return count;
}



start();








