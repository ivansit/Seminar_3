// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int xa = Prompt("Enter the coordinate of point A along the x axis: ");
int ya = Prompt("Enter the coordinate of point A along the y axis: ");
int za = Prompt("Enter the coordinate of point A along the z axis: ");
int xb = Prompt("Enter the coordinate of point B along the x axis: ");
int yb = Prompt("Enter the coordinate of point B along the y axis: ");
int zb = Prompt("Enter the coordinate of point B along the z axis: ");


int Prompt(string message){
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double abz = Math.Sqrt(Math.Pow((ya-xa), 2) + Math.Pow((yb-xb), 2) + Math.Pow((zb-za), 2));
Console.WriteLine(abz);