// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Input five-digit number: ");
string? number = Console.ReadLine();

void CheckingNumber(string num){
    if (num[0] == num[4] && num[1] == num[3]){
        Console.WriteLine($"Your number: {number} - is palindrome");
    }
    else Console.WriteLine($"Your number: {number} - is not palindrome");
}

if (number.Length == 5){
    CheckingNumber(number);
}
else Console.WriteLine("Input correct (five-digit) number!");