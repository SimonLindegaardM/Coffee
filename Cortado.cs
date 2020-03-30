namespace Coffee
{
    public class Cortado : Coffee, IMilk
    {
        public int mlMilk()
        {
            return 40;
        }

        public override int Price()
        {
            return 25;
        }
        public override string Strength()
        {
            return "Medium";
        }
        public override string ToString()
        {
            return Strength();
        }
    }
}