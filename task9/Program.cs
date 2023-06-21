// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Возводим число А в натуральную степень числа Б");

int AvStepeniB(int numA, int numB){
  int value = 1;
  for (int i = 1; i <= numB; i++){
    value *= numA;
  }
  return value;
}

Console.Write("Введите число А: ");
int chisloA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б: ");
int chisloB = Convert.ToInt32(Console.ReadLine());

int a_v_stepeni_b = AvStepeniB(chisloA, chisloB);
Console.WriteLine($"Результат: {a_v_stepeni_b}");