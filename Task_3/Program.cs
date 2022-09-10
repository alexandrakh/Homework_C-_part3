//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}
int n = Prompt("Введите число N: ");
for (int i = 0; i <= n; i++)
{
    int result = i*i*i;
    Console.WriteLine(result);
}