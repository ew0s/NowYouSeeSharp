using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t20
{
    /*
     * Проанализируйте текущий код программы. Внутри класса MagicBank создайте две публичных статических коллекции:
     *      1) Коллекцию AllClients, которая должна содержать в себе экземпляры всех возможных клиентов банка
     *         и хранящая идентификатор их банковского счёт в качестве ключа.
     *      2) Перечень счетов на оплату (AllChecks), представленный в виде очереди ссылочных элементов, каждый из которых будет содержать:
     *         2.1) Id клиента (clientId), которому выставили счёт.
     *         2.2) Сумму (total), подлежащую оплате.
     *  В отдельном файле создайте класс Check, содержащий все указанные выше публичные поля, а так же конструктор
     *  принимающий и устанавливающий соответствующие значения. Содержимое метода Main() изменять нельзя, при этом
     *  программа должна компилироваться.
     *  Исправьте логику полученной программы таким образом, чтобы:
     *      1) В случае если денег на счету клиента недостаточно для оплаты счёта - вызывался метод отклоняющий проведение платежа.
     *      2) В случае если платёж отклонён - счёт должен быть заблокирован, а в случае повторной попытки проведения платежа -
     *         его счета и сведения о клиенте удалялись из текущего списка клиентов банка.
     */

    public class MagicBank
    {
        public static Dictionary<string, AnimalClient> AllClients { get; set; } = new Dictionary<string, AnimalClient>();
        public static Queue<Check> AllChecks { get; set; } = new Queue<Check>();
        
        public static void Main(string[] args)
        {
            while (AllChecks.Count != 0)
            {
                var check = AllChecks.Dequeue();
                if (AllClients.ContainsKey(check.clientId))
                {
                    AllClients[check.clientId].Pay(check.total);
                }
            }
        }
    }
}
