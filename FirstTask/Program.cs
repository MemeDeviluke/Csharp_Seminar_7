// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int ReadInt(string text){

    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}


void ShowNaturNumbers(int M, int N){

    if(M > N){
        return;
    }
    else{
        System.Console.Write(M + " ");
        ShowNaturNumbers(M + 1, N);
    }

}

int M = ReadInt("Введите значение M (Значение M должно быть меньше N): ");
int N = ReadInt("Введите значение N (Значение N должно быть больше M): ");

ShowNaturNumbers(M, N);
