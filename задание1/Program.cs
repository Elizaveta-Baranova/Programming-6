// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа: ");
string numberString = Console.ReadLine();

int count = 1;
int minus = 0;
for (int i = 0; i < numberString.Length; i++)
{
    if(numberString[i] == ',')
    count++;
    if(numberString[i] == '-')
    minus++;
}
count = count-minus;
Console.Write("Положительных чисел: " + count);