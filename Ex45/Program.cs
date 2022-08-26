int length = 0;
while (length <= 0)
{
    Console.WriteLine("Введите корректную длину массива:");
    length = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-10, 11);
}
Console.WriteLine($"{String.Join(" ", array)}");

int[] copiedArray = new int[length];
for (int j = 0; j < length; j++)
{
    copiedArray[j] = array[j];
}
Console.WriteLine($"{String.Join(" ", copiedArray)}");