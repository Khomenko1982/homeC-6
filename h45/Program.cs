// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

const int ARR_SIZE=12;
const int LEFT_RANGE=-10;
const int RIGHT_RANGE=10;

int[] array = fillarr(ARR_SIZE,LEFT_RANGE,RIGHT_RANGE);
int[] copyArray =CopyArray(array);

array[0]=100; // это проверка что массивы в результае копирования разные
Console.WriteLine("Исходный массив :");
Console.WriteLine(String.Join(", ",array));
//CopyArray(array); // выполнение метода
Console.WriteLine("Скопированный массив :");
Console.WriteLine(String.Join(", ",copyArray));

// Метод возвращает массив на size элементов 
int[] fillarr(int size, int lefts, int rights)
{
int[] array =new int[size];

Random random= new Random();
for ( int i=0; i< size; i++ )
{
    array[i]=random.Next(lefts,rights+1);
}
return array;
}
// Метод поэлементного копирования исходного массива массива
int[] CopyArray(int[] sourceArray)
{
    int[] destinationArray =new int[sourceArray.Length];
    for ( int i=0; i< sourceArray.Length ; i++ )  
{
     
    destinationArray[i]=sourceArray[i];
}
return destinationArray;
}