using System;
namespace Inheritance
{ 



    public class Program
    {


        public  static void Main(string[] arg)
        {



            Bird myBird = new Bird(); //step 9 create object (myBird)
            {
                
                myBird.IsAlive = true;
                myBird.DoesItFly = true;
                myBird.ItsDiet = "grass";
                myBird.IsItInjured = false;
            }
            
            


           




            Reptile myReptile = new Reptile();
            {
                myReptile.YearsOld = 2;
                myReptile.CanSwim = true;
                myReptile.DoesItReproduce = true;
                myReptile.FoundInAmazon = true;
            }

            Animal[] animalArray = new Animal[2];
            animalArray[0] = myBird;
            animalArray[1] = myReptile;


             

            


            
            Console.WriteLine();//step 11 call method to main
            myBird.AnimalDetails();
            myReptile.ReptileDetails();





       }

    }




}



