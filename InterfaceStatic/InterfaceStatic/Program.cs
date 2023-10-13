using InterfaceStatic.Extensions;
using InterfaceStatic.Interfaces;
using InterfaceStatic.Models;

namespace InterfaceStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            //Eagle eagle = new Eagle
            //{
            //    AvgLifetime=20,
            //    ClawPower=200,
            //    Gender="female",
            //    HasEgg=false,
            //    FlySpeed=100
            //};

            //eagle.Fly();

            //Penguin penguin = new Penguin
            //{
            //    AvgLifetime = 6,
            //    Gender = "male",
            //    HasEgg = true,
            //    IsSingle=true,
            //    SwimSpeed=50
            //};
            //penguin.Swim();

            //Duck duck = new Duck() { FlySpeed=20};

            //Plane plane = new Plane() { FlySpeed=1000};

            //duck.Fly();
            //duck.Swim();




            //duck.Fly();
            //plane.Fly();
            //eagle.Fly(); 


            //IFly[] flies = { duck, plane, eagle};


            //foreach (IFly flyItem in flies)
            //{
            //    flyItem.Fly();


            //    Console.WriteLine(flyItem.FlySpeed);
            //}

            //ISwim[] swims = { duck, penguin };
            #endregion

            #region Static Extension
            //Person person = new Person() { Name = "Fidan", Surname = "Behbudova" };



            //person.GetName();
            //Console.WriteLine(person.Id);

            //Person person2 = new Person();
            //Console.WriteLine(person2.Id);

            //Person person3 = new Person();
            //Console.WriteLine(person3.Id);

            //Person person4 = new Person();
            //Console.WriteLine(person4.Id);

            //Person person5 = new Person();
            //Console.WriteLine(person5.Id);



            //Console.WriteLine(Person.Count);

            //Person.RetirementAge = 65;


            //Console.WriteLine(Person.RetirementAge);





            //Helper.Capitalize("reX");


            //Console.Beep();





            string name = "saBIR";

            //Helper.Capitalize(name);

            name.Capitalize();

            int num = 2;


            //Helper.Squared(num);

            //num.Power(6);


            #endregion

        }
    }
}