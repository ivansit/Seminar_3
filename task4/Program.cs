// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = Prompt("Enter the number: ");
int i = 1;

int Prompt(string message){
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Cube(int num){
while (i <= num)
{
    double pow_i = Math.Pow(i, 3);
    Console.Write(pow_i + " ");
    i++;
}
}
Cube(num);