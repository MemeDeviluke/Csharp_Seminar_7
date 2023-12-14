// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int ReadInt(string text){

    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

int AckermanFunction(int m, int n){

    if(m == 0) {

        return n + 1;

    }

    else if(m > 0 && n == 0){

        return AckermanFunction(m - 1, 1);

    }

    else{

        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));

    }

}



int m = ReadInt("Введите значение m: ");
int n = ReadInt("Введите значение n: ");

int AckermanFunctionNumber = AckermanFunction(m, n);

System.Console.Write(AckermanFunctionNumber);