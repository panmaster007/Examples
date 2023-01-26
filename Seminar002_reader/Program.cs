Console.WriteLine("Введите первое число");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int j = Convert.ToInt32(Console.ReadLine());
int sum = (int)Math.Pow(i, 2);
if (sum == j)
    {
    Console.WriteLine("Да, первое число является квадратным корнем от второго");
    }
    else
    {
    Console.WriteLine("Нет, первое число не является квадратным корнем второго");
    }

   Console.WriteLine("Введите номер дня недели от  1 до 7");
   int n = Convert.ToInt32(Console.ReadLine());
   if  (n == 1)
   {
   Console.WriteLine("День недели понедельник"); 
   }
   else if  (n == 2)
   {
   Console.WriteLine("День недели вторник"); 
   }
   else if  (n == 3)
   {
   Console.WriteLine("День недели среда"); 
   }
   else if  (n == 4)
   {
   Console.WriteLine("День недели четверг"); 
   }
   else if  (n == 5)
   {
   Console.WriteLine("День недели пятница"); 
   }
   else if  (n == 6)
   {
   Console.WriteLine("День недели суббота"); 
   }
   else if  (n == 7)
   {
   Console.WriteLine("День недели воскресенье"); 
   }
   else if (n > 7) 
   {
    Console.WriteLine("Такого дня недели не бывает");
   }