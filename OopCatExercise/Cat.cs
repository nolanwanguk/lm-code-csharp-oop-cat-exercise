using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		public bool IsAsleep=false;
		public  string Setting { get; set; }
		public  int AverageHeight { get; set; }

		

		public void WakeUp()
        {
			IsAsleep=false;
        }
		public void GoToSleep()
        {
			IsAsleep = true;
        }
		public abstract string Eat();
	}

	public class DomesticCat : Cat
    {
		string Setting = "domestic";
		int AverageHeight = 23;
		public override string Eat()
        {
			return "Purrrrrrr";

		}
    }
	public class LionCat : Cat
	{
		
		int AverageHeight = 1100;
		public override string Eat()
		{
			return "Roar!!!!";

		}
	}
	public class CheetahCat : Cat
	{
		string Setting = "cheetah";
		
		public override string Eat()
		{
			return "Zzzzzzz";

		}
	}
}
