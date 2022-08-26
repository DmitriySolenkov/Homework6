int num = 0;
while (num <= 2)
{
    Console.WriteLine("Введите число более 2:");
    num = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[num];
array[0] = 0;
array[1] = array[2] = 1;
for (int i = 2; i < num; i++)
{
    array[i] = array[i - 1] + array[i - 2];
}
Console.WriteLine($"{String.Join(" ", array)}");

