//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void tochka_peresech (double k1, double b1, double k2,double b2)
{
    double x;
    double y;
    if ((k1==k2) && (b1==b2))
        Console.WriteLine("Ты ввел одинаковые прямые, они везде пересекаются");
    else if (k1==k2)
        Console.WriteLine("Прямые параллельные");
    else
    {
        x=(b2-b1)/(k1-k2);
        y=(k1*(b2-b1))/(k1-k2)+b1;
        Console.WriteLine("X точки пересечения ==");
        Console.WriteLine(x);
        Console.WriteLine("Y точки пересечения ==");
        Console.WriteLine(y);
    }
    


}
double k1;
double k2;
double b1;
double b2;
Console.WriteLine("Привет");
Console.WriteLine("Введите к1");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите к2");
k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
b2 = Convert.ToDouble(Console.ReadLine());
tochka_peresech(k1,b1,k2,b2);
