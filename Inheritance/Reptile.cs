using System;											//Animal class is base
namespace Inheritance									// Reptile class is derived
{               //step6 Create Reptile class
	public class Reptile : Animal//Step 8 have it inherit from animal class.
	{
		public int YearsOld { get; set; }//step 7 create 4 members
		public bool CanSwim { get; set; }
		public bool FoundInAmazon { get; set; }
		public bool DoesItReproduce { get; set; }

		public Reptile()
		{
			IsAlive = true;
            HaveFur = true;
            Age = 3;
            

        }

		public  void ReptileDetails()
		{
			Console.WriteLine($"How old is this reptile?{YearsOld}.");
            Console.WriteLine($"Can this reptile swim?{CanSwim}.");
            Console.WriteLine($"True or false, Is it found in the amazon? {FoundInAmazon}.");


        }


    }
}

