// Напишите программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно задать или ввести с клавиатуры.

string[] array = new string[]{
        "1S01", ">kz", "1S01", "1S01", "1S01", "1S02", "1S02",
        "1S02", "1H01", "1H01", "1S02", "1S01", "1", "1H01",
        "1H01", "1H01", "1S02", "Юля", "1M02", "1M02", "1M02"};

Console.WriteLine("[" + string.Join(", ", array) + "]");

void SelectThreeSymbol(string[] array, int count) {
    int lenOfarray = array.Length;
    string[] arraySelect = new string[lenOfarray];
    int countOfString = 0;

    for(int i = 0; i < lenOfarray; i++) {
        if(array[i].Length <= count) {
            arraySelect[countOfString] = array[i];
            countOfString++;
        }
    }
    Array.Resize(ref arraySelect, countOfString);
    Console.WriteLine("[" + string.Join(", ", arraySelect) + "]");
}

SelectThreeSymbol(array, 3);

