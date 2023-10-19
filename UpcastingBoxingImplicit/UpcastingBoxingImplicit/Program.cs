using UpcastingBoxingImplicit.Models;

namespace UpcastingBoxingImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting Downcasting Boxing Unboxing

            //Dog dog = new Dog { AvgLifetime=12,Breed="Golden retriever",Name="Bobik"};
            //Eagle eagle = new Eagle { AvgLifetime=25,FlySpeed=200,Name="Shahingozlum"};
            //Animal[] animals = {eagle, dog }; //Upcasting


            //object[] objects= {dog,eagle,"Salam",45m,'A'}; boxing

            //Dog dog3 = (Dog)objects[0];  unboxing


            //foreach (var animal in animals)
            //{

            //Downcasting
            //Dog dog2 = (Dog)animal; 1)explicit

            //Dog dog2 = animal as Dog; 2)As casting operator

            //if (animal is Dog dog2) 3) is casting operatoru deyil!!!!!!!!!!!
            //{
            //    Console.WriteLine(dog2.Breed);
            //    dog2.Bark();
            //}


            //}






            //Animal animal = new Dog { AvgLifetime = 12, Breed = "Golden retriever", Name = "Bobik" }; ;
            //Animal animal2 = new Eagle(); implicit


            //Dog dog = (Dog)animal2;

            //dog.Bark();

            //Console.WriteLine(dog.Name+" "+dog.Breed);
            //dog.Bark(); 
            #endregion



            #region Implicit Explicit
            //Dollar dollar = new Dollar(123);

            //Manat manat = new Manat(340);

            //manat = (Manat)dollar;

            //dollar = (Dollar)manat;

            //manat = dollar;

            //dollar = manat;


            //manat = 500m;
            //Console.WriteLine(manat.Azn); 
            #endregion




            Manat manat = new Manat(50);
            Manat manat2 = new Manat(100);

            //manat = manat + manat2;
            //manat += manat2;


            Console.WriteLine(manat.Azn);
            //Console.WriteLine(manat == manat2); 
            //Console.WriteLine(manat > 200m);


        }
    }
}