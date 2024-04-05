using System;
namespace Inheritance
{               //Step1 Create animal class
	public  class Bird : Animal//step 5 Make it inherit from animal class
	{
		public bool DoesItFly { get; set; }//Step4 give 4 members
		public string ItsDiet { get; set; }
		public string ColorOfBeak { get; set; }
		public bool IsItInjured { get; set; }


		public Bird()
		{

			IsAlive = true;//step 9 inherit values from Animal class
			HaveFur = true;
			IsItInjured = false;
			Age = 3;
			

		}

		// no need for static

		public  void AnimalDetails() //step 10 Create Method  to display values
		{
            
            Console.WriteLine($"True or False,a bird fly? {DoesItFly}.");
			Console.WriteLine($"What does it eat? {ItsDiet}.");
			Console.WriteLine($"True or False, Does a bird have fur? {HaveFur}.");
			Console.WriteLine($"What is the birds age? {Age}.");
			






    }	}
}

