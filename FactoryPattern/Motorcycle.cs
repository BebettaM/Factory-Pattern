﻿using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
		}

		public void Drive ()
		{
			Console.WriteLine("The Motorcycle is revving up!");
			Console.WriteLine("vroooooooom");
		}
	}
}

