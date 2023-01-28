Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int count = n * -1;
while (count <= n)
{
    Console.WriteLine(count ++);
}