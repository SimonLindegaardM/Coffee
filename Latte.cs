namespace Coffee
{
    public class Latte : Coffee, IMilk
    {
        public int mlMilk()
        {
            return 200;
        }

        public override int Price()
        {
            return 40;
        }
        public override string Strength()
        {
            return "Weak";
        }
        public override string ToString()
        {
            return Strength();
        }
    }
}