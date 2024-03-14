Console.WriteLine("Введите строку: ");
string str = Console.ReadLine().ToLower();

bool flag = true;

for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] != str[str.Length - i - 1])
    {
        flag = false;
        break;
    }
}

if (flag)
{
    Console.WriteLine("Строка является палиндромом.");
}
else
{
    Console.WriteLine("Строка не является палиндромом.");
}