// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
const int ARR_SIZE=12;
const int LEFT_RANGE=-10;
const int RIGHT_RANGE=10;

int[] array = fillarr(ARR_SIZE,LEFT_RANGE,RIGHT_RANGE);
Console.WriteLine("Исходный массив :");
Console.WriteLine(String.Join(", ",array));
ReverseArray(array); // выполнение метода
Console.WriteLine("Перевернутый массив :");
Console.WriteLine(String.Join(", ",array));

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
// 
// Метод переворота массива
void ReverseArray(int[] array)
{
    for ( int i=0; i< array.Length / 2; i++ ) // работаем только с половиной массива, так как для реверса  этого достаточно  
{
    int temp = array[i]; // темповая переменная для хранения элемента массива
    array[i]=array[array.Length - 1 - i]; //замена начальнго элемента на конечный
    array[array.Length - 1 - i]=temp;  
}
}