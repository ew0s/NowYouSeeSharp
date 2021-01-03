using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t25
{
    /*
     * На вход в метод Main() подается массив строк, который содержит сведения из некоторого системного журнала логов.
     * Каждая строка - это отдельный лог, событие, которое произошло и было зафиксировано. Нам необходимо вычислить
     * пользователей, которые являются спамерами, и добавить их IP-адрес в список заблокированных.
     * Формат строки лога:
     * ID_EVENT_USER_DATETIME_STATUS, где:
     *      1) ID - число, ID лога;
     *      2) EVENT - строка с типом события (message, act, request);
     *      3) USER - строка с учетной записью пользователя;
     *      4) DATETIME - числовое представление даты создания события;
     *      5) STATUS - строка с информацией о статусе события.
     * Список всех пользователей и их IP-адресов находится переменной allUsers, где ключ это учетная запись пользователя.
     * Список заблокированных пользователей и их IP-адреса должны находится в переменной blockedUsers.
     * Логика определения спамеров должна быть следующая:
     *      1) Если пользователь оправляет сообщение (event - message) чаще чем 1 раз в 5 секунд.
     *      2) Если пользователь отправляет запрос чаще чем 1 раз в 2 секунды.
     * Выведите в консоль всех заблокированных пользователей в формате: "ACCOUNT_SURNAME_NAME - IP" каждое значение с новой строки, где:
     *      ACCOUNT - учетная запись пользователя;
     *      SURNAME - фамилия пользователя;
     *      NAME - имя пользователя;
     *      IP - IP-адрес пользователя.
     * Вся логика работы программы должна быть реализована в методе Main(), остальные элементы шаблона изменять нельзя.
     */

    public class Analyzer
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<string, long> messageSpammers = new Dictionary<string, long>();
            Dictionary<string, long> requestSpammers = new Dictionary<string, long>();

            foreach (string value in args)
            {
                string action = value.Split('_')[1];
                string user = value.Split('_')[2];
                long time = Convert.ToInt64(value.Split('_')[3]);

                if (Program.blockedUsers.ContainsKey(user)) continue;

                switch (action)
                {
                    case "message":
                    {
                        if (messageSpammers.ContainsKey(user))
                        {
                            TimeSpan difference = new DateTime(time) - new DateTime(messageSpammers[user]);
                            if (Math.Abs(difference.TotalSeconds) < 5)
                            {
                                Program.blockedUsers.Add(user, Program.allUsers[user]);
                                continue;
                            }
                        }

                        messageSpammers[user] = time;
                        break;
                    }
                    case "request":
                    {
                        if (requestSpammers.ContainsKey(user))
                        {
                            TimeSpan difference = new DateTime(time) - new DateTime(requestSpammers[user]);
                            if (Math.Abs(difference.TotalSeconds) < 2)
                            {
                                Program.blockedUsers.Add(user, Program.allUsers[user]);
                                continue;
                            }
                        }

                        requestSpammers[user] = time;
                        break;
                    }
                }
            }

            foreach (KeyValuePair<string, UserInfo> blockedUser in Program.blockedUsers)
            {
                Console.WriteLine($"{blockedUser.Value.Account}_{blockedUser.Value.Surname}_{blockedUser.Value.Name} - {blockedUser.Value.IP}");
            }
        }
    }

    public static class Program
    {
        public static Dictionary<string, UserInfo> allUsers = new Dictionary<string, UserInfo>();
        public static Dictionary<string, UserInfo> blockedUsers = new Dictionary<string, UserInfo>();
        static Program()
        {
            allUsers.Add("StormRage", new UserInfo("StormRage", "10.11.12.168", "Рядовой", "Билли"));
            allUsers.Add("Pepe", new UserInfo("Pepe", "192.196.11.21", "Жабка", "Пепе"));
            allUsers.Add("Guffi", new UserInfo("Guffi", "192.11.51.168", "Джон", "Гук"));
            allUsers.Add("CatTim", new UserInfo("CatTim", "33.7.122.225", "Тим", "Кот"));
        }
    }

    public class UserInfo
    {
        public string Account { get; set; }
        public string IP { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public UserInfo(string account, string ip, string name, string surname)
        {
            Account = account;
            IP = ip;
            Name = name;
            Surname = surname;
        }
    }
}