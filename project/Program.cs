// Добавляйте новые числа в список до тех пор, пока пользователь не введет 0.
// Выведите в консоль сумму и произведение всех элементов списка.
// Выведите средннее, среди всех элементов списка.

using System;
using System.Collections.Generic;
class work_1_2
{
    static void Main()
    {
        List<float> array = new List<float>();
        float sum = 0; 
        float multiplication = 1; 
        
        while (true) 
        {
            Console.Write("Введите число: "); 
            float number = float.Parse(Console.ReadLine()); 
            if (number == 0)
            {
                break;
            }
            sum += number;  
            multiplication *= number; 
            array.Add(number); 
        }
        float average = sum / array.Count; 
        
        var str = string.Join(" ", array);        
        Console.WriteLine(str);
        Console.WriteLine($"Сумма: {sum} \t Произведение: {multiplication} \t Среднее значение: {average}");
    }
} 
