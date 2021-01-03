using System.Threading;

namespace l7t13
{
    public class ProxyClass
    {
        public static Descriptor descriptor = new Descriptor();
        public static Thread thread;
        public static Thread anotherThread;

        public void PepeStarter()
        {
            descriptor.PepePrinter();
        }

        public void JohnStarter()
        {
            descriptor.JohnPrinter();
        }

        public ProxyClass()
        {
            thread = new Thread(PepeStarter);
            anotherThread = new Thread(JohnStarter);
            thread.Start();
            anotherThread.Start();
        }
    }
}
