﻿using System;
using System.Linq;
using System.Collections.Generic;

class ParamsExample
{
	static void Main(string[] args)
	{
		int[,] myArray = new int[10, 6];

		Random random = new Random();

		for (int i = 0; i < myArray.GetLength(0); i++)
		{
			for (int j = 0; j < myArray.GetLength(1); j++)
			{
				myArray[i,j] = random.Next();
			}
			
		}

		for (int y = 0; y < myArray.GetLength(0); y++)
		{
			for (int x = 0; x < myArray.GetLength(1); x++)
			{
				Console.Write(myArray[y, x] + "\t");
			}
			Console.WriteLine();
		}
		Console.ReadKey();
	}
}



