using System;

class SquaredArray
{
    private readonly double[] data;

    public SquaredArray(int size)
    {
        data = new double[size];
    }

    public double this[int index]
    {
        get
        {
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        set
        {
            if (index >= 0 && index < data.Length)
            {
                data[index] = value * value; // Возводим в квадрат переданное значение
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        SquaredArray arr = new SquaredArray(5);

        // Установка значений с использованием индексатора
        arr[0] = 2.0;
        arr[1] = 3.5;
        arr[2] = 1.5;
        arr[3] = 4.0;
        arr[4] = 2.5;

        // Получение значений с использованием индексатора и вывод на экран
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"arr[{i}] = {arr[i]}");
        }
    }
}
