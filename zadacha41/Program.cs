//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

string s;
int count_s;
int countplus=0;
Console.WriteLine("Вводи числа, через пробел");
s = Convert.ToString(Console.ReadLine());
Console.WriteLine("Ты ввел");
Console.WriteLine(s);
Console.WriteLine("Длина строки");
count_s = s.Length;
Console.WriteLine(count_s);

string[] chisla = s.Split(new char[] { ' ' });
int count_chisla = chisla.Length;
Console.WriteLine("Кол-во элементов в массиве после разделения");
Console.WriteLine(count_chisla);
Console.WriteLine("Вот такой вот массив получился");
for(int i=0;i<count_chisla;i++)
{
    Console.WriteLine(chisla[i]);
    if (Convert.ToInt32(chisla[i])>0)
        countplus++;
}

Console.WriteLine("Количество чисел больше 0");
Console.WriteLine(countplus);
