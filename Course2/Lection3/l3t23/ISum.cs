namespace l3t23
{
    public interface ISum
    {
        long Sum(int a, int b);
        int Sum(short a, short b);
        short Sum(byte a, byte b);
        float Sum(double a, double b);
        float Sum(int a, double b);
    }
}
