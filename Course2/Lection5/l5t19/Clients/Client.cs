using System.Collections.Generic;

namespace l5t19
{
    public abstract class Client
    {
        public List<IEatable> order = new List<IEatable>();
        public bool HaveSpecialNeeds { get; set; }
    }
}
