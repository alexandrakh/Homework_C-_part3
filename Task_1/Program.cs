//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string numberStr = Console.ReadLine();
string GetPolindrom(string number)
{
    int digits = numberStr.Length;
    if (digits == 5)
    {
        if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
        {
            return "Это полиндром";
        }
        else
            return "Это не полиндром";
    }
    else
        return "Введено неверное число. Введите пятизначное число:";

}
System.Console.WriteLine(GetPolindrom(numberStr));