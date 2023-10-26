using SolidExamples.DIP;
using SolidExamples.Liskov;
using SolidExamples.OCP;

namespace SolidExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IMeal meal= new MushedPotato();
            //IMeal meal2 = new FrenchFries();
            //IMeal meal3 = new Tomato();

            //Chef chef = new Chef();

            //chef.MakeMeal(meal);
            //chef.MakeMeal(meal2);
            //chef.MakeMeal(meal3);



           // FlyShow<Eagle> flyShow = new FlyShow<Eagle>();

           //flyShow.StartShow();


            //Eagle eagle = new Eagle();
            //eagle.Fly();
            //eagle.Swim();


            //Knife knife = new Knife();

            Scissor scissor=new Scissor();

            Pizza pizza = new Pizza(scissor);

            pizza.CutPizza();

        }
    }
}