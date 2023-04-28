// Катер плывёт  против течения. Нужно посчитать время которое будет затрачено на рейс от одного  порта к другому. 
// Пользователь вводит
// скорость катера, расстаяние между городами, скорость течения.

void start()
{
        Console.Write("Введите скорость катера миль в час  ");
        double speed1 = Revisor();

        Console.Write("Введите скорость течения миль в час: ");
         double speedriver = Revisor();

        Console.Write("Введите расстояние между портами в милях : ");
         double distance = Revisor();

         double result = Result(speed1, speedriver, distance);
         Console.WriteLine($"Время, затраченное на рейс от порта A до порта B составляет {result} часов.");
}


double Revisor()
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



double Result(double speed1, double speedriver, double distance)
{
  
   if (distance < 0)
    {
        Console.WriteLine("Ошибка ввода. Расстояние между портами должно быть неотрицательным.");
        return -1;
    }
  
  
  
    if ( speed1 <= speedriver )
    {
        Console.WriteLine("Катер не двигается. Скорость катера меньше скорости течения!!! ");
        return(0);

    }
    double time = 0;
    time = (distance /(speed1-speedriver));
    return time;
}

start();