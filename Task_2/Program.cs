//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
//3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}
int sqr(int n)
{
    return (n * n);
}
int[] InputCoord(int n)
{
    int[] coord = new int[3];
    coord[0] = Prompt($"Введите x координаты {n} точки ");
    coord[1] = Prompt($"Введите y координаты {n} точки ");
    coord[2] = Prompt($"Введите z координаты {n} точки ");
    return coord;
}

int [] Coord1=InputCoord(1);
int [] Coord2=InputCoord(2);

double result = Math.Sqrt(sqr(Coord2[0] - Coord1[0]) + sqr(Coord2[1] - Coord1[1]) + sqr(Coord2[2] - Coord1[2]));
Console.WriteLine(result);




