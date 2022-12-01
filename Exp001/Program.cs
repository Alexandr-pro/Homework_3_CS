// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine(" >>>> Определить является ли число палиндромом <<<< ");
Console.Write(" Введите число: ");
int num, rem, sum = 0, temp;
                        
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (Convert.ToBoolean(num))
        {
            rem = num % 10;  
            num = num / 10; 
            sum = sum * 10 + rem; 
                       
        }
         Console.WriteLine(" Введенное число: {0} ", sum);
        if (temp == sum) 
        {
            Console.WriteLine("Является палиндромом ");
        }
        else
        {
            Console.WriteLine(" Не является палиндромом ");
        }
        Console.ReadLine();
