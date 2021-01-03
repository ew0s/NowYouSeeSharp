namespace l2t10
{
    public class Duck : Bird
    {
        public override Bird GetNewBird(string name)
        {
            return new Duck();
        }
    }
}