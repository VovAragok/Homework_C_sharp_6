// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void start()
{
        Console.Write("Введите значение b1 ");
        double b1 = revisor();

        Console.Write("Введите значение k1 : ");
         double k1 = revisor();

        Console.Write("Введите значение b2 : ");
         double b2 = revisor();

        Console.Write("Введите значение k2 : ");
         double k2 = revisor();

        double x = ResultX(b2,b1,k1,k2);
        double y = ResultY(k1,x,b1);
        Console.WriteLine($"точка пересечения двух прямых x ={x}, y = {y}");
}



double ResultX(double b2, double b1, double k1, double k2)
{
    double b = (b2 - b1) / (k1 - k2);
    return b;
}


double ResultY(double k1, double x, double b1)
{
  double y = k1 * x + b1;
  return y;
}


double revisor()
{ 
    double number;
    


    while(true)
    {
        Console.WriteLine("Введите число:");
        string s1 = Console.ReadLine();
        if (double.TryParse(s1, out number))
        {
            return number;  
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Это не число!");
        }
    }
}


start();