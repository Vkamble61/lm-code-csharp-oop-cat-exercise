using System;
//using System.Diagnostics.CodeAnalysis;
using OopCatExercise;

namespace OopCatExercise
{
    public abstract class Cat : ICat
    {
        public string Setting { get; set; }
        public bool IsAsleep { get; set; }
        public int AverageHeight { get; set; }

        public Cat()
        {
           
        }
        public abstract string Eat();

        public virtual void WakeUp() { }

        public virtual void GoToSleep() { }       


    }

    public class LionCat : Cat
    {
        public LionCat() : base()
        {
            AverageHeight = 1100;
        }


        public override string Eat()
        {
            return "Roar!!!!";
        }
        

    }
    public class CheetahCat : Cat
    {
        public CheetahCat() : base()
        {
            AverageHeight = 1100;
        }
        public override string Eat()
        {
            return "Zzzzzzz";
        }      


    }
    public class DomesticCat : Cat
    {
        public DomesticCat() : base()
        {
            IsAsleep = false;
            Setting = "domestic";
            AverageHeight = 23;
        }

        public override string Eat()
        {
            return "Purrrrrrr";
        }
        public override void GoToSleep()
        {
            IsAsleep = true;
        }

        public override void WakeUp()
        {
            IsAsleep = false;
        }

    }

}
