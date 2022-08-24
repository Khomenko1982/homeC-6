// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int f = 0;
Console.WriteLine("Введите количество M чисел, которые будете вводить далее :");
 int z = int.Parse(Console.ReadLine());            
            int[] array = new int[z];
 Index(array,z,f);

    static int[] Index(int[] array,int z,int f)
        {
             f = 0;
            do
            {
                if (f < z)
                {
                  Console.Write($"Введите  {z+1-z+f}-е число " );
                    array[f] = int.Parse(Console.ReadLine());
                   f++;
                }
            } while (f < z);
            return array; 
        }
        Console.WriteLine("Числа по порядку которые ввел пользователь :");
        Console.WriteLine(String.Join(", ",array));

        MoreZero(array); // Вызов метода
// метод поиска числа больше нуля
void MoreZero(int[] array)
{
  int count=0;
    for ( int i=0; i< array.Length; i++ ) 
{
    if (array[i]>0)
    {
      count++;
    }
    
}
 Console.Write("Количество чисел больше нуля : ");
 Console.Write(count);
}

// Тут немного интернет помог в части цикла преобразования вводимых данных в массив, в целом думаю работает правильно.