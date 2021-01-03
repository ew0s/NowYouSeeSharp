namespace l5t3
{
    public class Obj
    {
        public static void Fly(IFlyable animal)
        {
            animal.FlyAction();
        }

        public static void Move(IMovable animal)
        {
            animal.MoveAction();
        }
    }

}
