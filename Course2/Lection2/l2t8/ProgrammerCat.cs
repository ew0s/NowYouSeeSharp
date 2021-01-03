namespace l2t8
{
    public class ProgrammerCat : Cat
    {
        public int Money { get; set; }
        public override void DoWork(int payment)
        {
            base.Money += payment;
        }
    }
}