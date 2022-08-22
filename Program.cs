// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Инициализация массива строк
string[] baseArray = { "Sun", "Monday", "Tuersday","Wed", "Thirsday", "Fri", "Sat","1","12","123","1234" };
int count=0;
// Вывод начального массива строк baseArray
printArray(baseArray);

string[] createFinalArray(string[] baseArray)
{
    for (int i = 0; i < baseArray.Length; i++)
    {
    if(baseArray[i].Length <= 3)
        {
        count++;
        }
    }
    string[] finalArray = new string[count];
    count = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
    if(baseArray[i].Length <= 3)
        {
        finalArray[count] = baseArray[i];
        count++;
        }
    }
    return finalArray;
}
void printArray(string[] array)
{
    Console.WriteLine("["+string.Join(", ",array)+"]");
}
printArray(createFinalArray(baseArray));
