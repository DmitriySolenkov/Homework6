Console.WriteLine("Введите через пробел несколько чисел:");
int[] array = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(i=>int.Parse(i)).ToArray<int>();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]> 0)
    {
        count++;
    }
}
if(count==0)
{
Console.WriteLine($"Среди введенных чисел: нет чисел больше 0");
}
if(count==1)
{
Console.WriteLine($"Среди введенных чисел: {count} число больше 0");
}
if(count>1&&count<5)
{
Console.WriteLine($"Среди введенных чисел: {count} числа больше 0");
}
if(count>5)
{
Console.WriteLine($"Среди введенных чисел: {count} чисел больше 0");
}