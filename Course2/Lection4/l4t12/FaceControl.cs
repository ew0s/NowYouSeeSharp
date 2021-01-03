using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t12
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FaceControl : Attribute
    {
        public int minAge;
        public int maxAge;
        public int money;
        public bool isTechnoCool;
        public int maxCount = 100;
        public bool NightClubControl(Human human)
        {
            return minAge <= human.age && human.age < maxAge && human.money >= money && human.isTechnoCool == isTechnoCool;
        }
        public bool DanceClubControl(Human human)
        {
            return minAge <= human.age && human.isTechnoCool == isTechnoCool;
        }
        public bool KinderClubControl(Human human)
        {
            return human.age < maxAge;
        }

        public FaceControl() { }
    }
}
