/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]

[6 7 3 6] -> [6 3 7 6]
*/
int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);

    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length -1] + "]");
}

int[] reverseArray(int[] array)
 {
    int[] reversedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length - 1 - i];
    }  
    return reversedArray;
 }

int[] generatedArray = generateArray(8, 0, 10);
PrintArray(generatedArray);
int[] reversedArray = reverseArray(generatedArray);
PrintArray(reversedArray);