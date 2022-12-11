/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*int[] array = new int[3];
array[0] = 4;
array[1] = -3;
array[2] = 7;


int[] numbers = { 4, -3, 7};
int index = 0;

if (numbers % 2==1)
            {
                Console.WriteLine("число нечетное");
           
            }
            else
            {
                Console.WriteLine("Число четное");
            }
            */

/*int i;
 
            Console.Write("Введите число : ");
 
            i = int.Parse(Console.ReadLine());
 
            if (i % 2 == 0)
 
            {
 
                Console.Write("Введенное число является четным");
 
                Console.Read();
 
            }
 
            else
 
            {
 
                Console.Write("Введенное число нечетное");
 
                Console.Read();
            }
 */

 Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.Read());
    if (a % 2 == 0) 
        Console.WriteLine("Четное");
    else Console.WriteLine("Нечетное");
    Console.ReadKey();