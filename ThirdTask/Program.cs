//  Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();

    for(int i = 0; i < size; i++){

        array[i] = random.Next(leftRange, rightRange + 1);

    }

    return array;

}

int ReverseArray(int size, int[] array){

    if(size == 0){

        return array[0];

    }
    else{

        System.Console.Write(array[size] + " ");
        return ReverseArray(size - 1, array);

    }

}

System.Console.Write("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int leftRange = 0;
int rightRange = 100;

int[] array = GenerateArray(size, leftRange, rightRange);
System.Console.WriteLine("[" + string.Join(", ", array) + "]");

System.Console.Write(ReverseArray(size - 1, array));

