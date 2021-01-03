namespace l3t8
{
    public interface IReader
    {
        void ReadNews(string paper);
        string WriteNews(string body);
        void BuyPaper(string paper, int price);
    }
}
