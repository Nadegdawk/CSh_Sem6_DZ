Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task41": Task41(); break;
			case "Task43": Task43(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

void Task41()
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
{
    Console.WriteLine("Counting positive numbers");
    int m = ReadInt("quantity of numbers");
	int[] array = ArrayUser(m);
	PrintArray(array);
	Console.WriteLine();
	Console.WriteLine($"NumberPositive: {NumberPositive(array)}");
}

void Task43()
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

{
    Console.WriteLine("The point of intersection of two straight lines y = k1 * x + b1, y = k2 * x + b2");
    double k1 = ReadInt("k1");
	int b1 = ReadInt("b1");
	double k2 = ReadInt("k2");
	int b2 = ReadInt("b2");
	if (CheckingParallelism(k1, k2))
	{
		System.Console.WriteLine("Straight lines are parallel");
	}
	else 
	{
		System.Console.WriteLine($"X = {PointOfIntersectionX(k1, b1, k2, b2)}");
		System.Console.WriteLine($"Y = {PointOfIntersectionY(k1, b1, k2, b2, PointOfIntersectionX(k1, b1, k2, b2))}");
	} 
}

int ReadInt(string argumentName)            //ввод данных пользователем
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int[] ArrayUser(int count)
{
	int[] array = new int[count];
	for (int i = 0; i < count; i++)
	{
		array[i] = ReadInt($"number {i+1}");
	}
	return array;
}

void PrintArray(int[] array)		//печать массива
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

int NumberPositive(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0) count ++;
	}
	return count;
}

bool CheckingParallelism (double k1, double k2)
{
	return k1 == k2;
}

double PointOfIntersectionX (double k1, int b1, double k2, int b2)
{
	double x = (b2-b1)/(k1-k2);
	return x;
}

double PointOfIntersectionY (double k1, int b1, double k2, int b2, double x)
{
	double y = k1*PointOfIntersectionX(k1, b1, k2, b2) +b1;
	return y;
}