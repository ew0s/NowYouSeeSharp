using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace l4t12
{
    /*
     * Внутри класса NightWorld создайте 3 публичных статических свойства, который бы являлись
     * списками экземпляров класса Human:
     *      1) NightClub - в коллекции могут находиться только экземпляры класса Human старше 18 (включительно)
     *      и моложе 50 (не включительно) лет, как минимум с 300$ (включительно) в кармане и любящих техно-музыку.
     *      2) DanceClub - в коллекции могут находиться только экземпляры класса Human старше 55 (включительно)
     *      лет и которые любят техно-музыку.
     *      3) KinderClub - в коллекции могут находиться только экземпляры класса до 18 (не включительно) лет.
     *      4) Каждый клуб должен иметь максимальную вместимость - maxCount, равную 100 (включительно).
     * Создайте в отдельном файле атрибут FaceControl, который бы являлся валидационным атрибутом 
     * и определял возможность доступа экземпляров класса Human в тот или иной клуб и при этом покрывал
     * все необходимые условия и ограничения по работе клубов. Атрибут не должен иметь никаких конструкторов, кроме 
     * конструктора по умолчанию. Область применения атрибута определите самостоятельно.      
     * Для каждого из клубов внутри класса NightWorld реализуйте публичный статический метод FaceControl(), который должен:
     *      1) Ничего не возвращать.
     *      2) Принимать переменную клуба и экземпляр класса Human.
     *      3) В случае если экземпляр класса Human подходит под текущие ограничения клуба и клуб не заполнен до предела, то
     *         метод должен пропускать его в клуб - добавив его в соответствующую переменную.
     *         
     * Логику работы своей программы можно проверить в методе Main(), он не будет участвовать в проверке.
     * Шаблон класса Human изменять нельзя.
     */

    public class NightWorld
    {
        [FaceControl(minAge = 18, maxAge = 50, money = 300, isTechnoCool = true)]
        public static List<Human> NightClub { get; set; } = new List<Human>();
        [FaceControl(minAge = 55, isTechnoCool = true)]
        public static List<Human> DanceClub { get; set; } = new List<Human>();
        [FaceControl(maxAge = 18)]
        public static List<Human> KinderClub { get; set; } = new List<Human>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static void FaceControl(List<Human> club, Human human)
        {
            try
            {
                FaceControl att;
                if (club.Equals(NightClub))
                {
                    att = (FaceControl)typeof(NightWorld).GetProperty(nameof(NightClub)).GetCustomAttribute(typeof(FaceControl));
                    if (att.NightClubControl(human) && club.Count < att.maxCount) club.Add(human);
                }
                else if (club.Equals(DanceClub))
                {
                    att = (FaceControl)typeof(NightWorld).GetProperty(nameof(DanceClub)).GetCustomAttribute(typeof(FaceControl));
                    if (att.DanceClubControl(human) && club.Count < att.maxCount) club.Add(human);
                }
                else if (club.Equals(KinderClub))
                {
                    att = (FaceControl)typeof(NightWorld).GetProperty(nameof(KinderClub)).GetCustomAttribute(typeof(FaceControl));
                    if (att.KinderClubControl(human) && club.Count < att.maxCount) club.Add(human);
                }
                else
                {
                    club.Add(human);
                }
            }
            catch { }
        }
    }
}
