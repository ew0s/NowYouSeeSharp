using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t5
{
    /*
     * Иногда даже абстрактные элементы в сочетании друг с другом могут создавать более конкретные элементы. 
     *  
     * Внутри класса Car созданы свойства определённых типов, каждый из которых сейчас является 
     * элементом описания экземпляров класса Car. Определите, какие из них могут существовать как 
     * отдельные классы (и в этом есть смысл), а какие следует заменить на более простые конкретные типы. 
     * Измените тип свойств класса Car в соответствии с получившейся логикой. 
     */

    public class Car
    {
        public Wheel Wheel { get; set; }
        public string WheelMarkName { get; set; }
        public int WheelCount { get; set; }
        public Manufacture Manufacture { get; set; }
        public int SerialNumber { get; set; }
        public Driver Driver { get; set; }
        public string DriverName { get; set; }
        public Fuel Fuel { get; set; }
        public bool CanMove { get; set; }
        public int TankVolume { get; set; }
        public int AverageSpeed { get; set; }
        public bool IsStarted { get; set; }
        public string Passenger { get; set; }
        public Weight Weight { get; set; }
        public Speed Speed { get; set; }
    }

    public class Wheel { };
    public class WheelMarkName { };
    public class WheelCount { };
    public class Manufacture { };
    public class SerialNumber { };
    public class Driver { };
    public class DriverName { };
    public class Fuel { };
    public class CanMove { };
    public class TankVolume { };
    public class AverageSpeed { };
    public class IsStarted { };
    public class Passenger { };
    public class Weight { };
    public class Speed { };
}
