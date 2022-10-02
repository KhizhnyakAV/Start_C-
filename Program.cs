System.Console.WriteLine("Является ли число квадратом другого числа?");
System.Console.WriteLine("Введите первое число:");

string input = Console.ReadLine();
int one = int.Parse(input);

System.Console.WriteLine("Введите второе число:");

input = Console.ReadLine();
int two = int.Parse(input);

//расчёт
if (one*one == two) {System.Console.WriteLine("Второе число является квадратом первого");};
if (two*two == one) {System.Console.WriteLine("Первое число является квадратом второго");};