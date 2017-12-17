namespace projInsurancePolicy
{
    public class Occupation
    {
        public virtual double getPremium()//virtual method is used in the main class which can be overridden by the subclass method which inherit this class
        {
            return 500;
        }
    }

    class Accountant : Occupation//class inherit the Occupation class
    {
        public override double getPremium()//overrides the getPremium method from the superclass
        {
            return (500 * 0.90);//decreases the premium by 10% and returns the value
        }
    }

    class Chauffeur : Occupation
    {
        public override double getPremium()
        {
            return (500 * 1.10);
        }
    }
}

