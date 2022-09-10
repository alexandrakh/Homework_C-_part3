//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

 int Prompt(string message)
  {
      Console.Write(message);
      string value = Console.ReadLine();
     return Convert.ToInt32(value);
  }

 bool GetPolindrom(int number)
 {
    string numberStr = number.ToString(); 

     for(int i=0;i<numberStr.Length/2;i++)
        {
          
             if(numberStr[i] != numberStr[numberStr.Length - i -1])
                return false;
          
        }
    
 return true;
 }   


int number = Prompt("введите число: ");

if (GetPolindrom(number))
{
    Console.WriteLine("Это полиндром");
}
else
 Console.WriteLine("Это не полиндром");