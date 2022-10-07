using System;
namespace Geo
{
    abstract class GeoObj
    {
        protected int X_coor;
        protected int Y_coor;
        protected string name;
        protected string description;

        public GeoObj(int X_coor, int Y_coor, string name, string description)
        {
            this.X_coor = X_coor;
            this.Y_coor = Y_coor;
            this.name = name;
            this.description = description;
        }
        
        public virtual void GetInformation()
        {
            Console.WriteLine($"X: {X_coor}\nY: {Y_coor}\nName: {name}\nDescription: {description}");
        }
    }
    class River: GeoObj
    {
        private double speed;
        private int lenght;

        public River(int X_coor, int Y_coor, string name, string description, double speed, int lenght): base(X_coor, Y_coor, name, description)
        {
            this.speed = speed;
            this.lenght = lenght;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.Write($"Speed: {speed}\nLength: {lenght}");
        }
    }
    class Mountain : GeoObj
    {
        private int highest_point;
        public Mountain(int X_coor, int Y_coor, string name, string description, int highest_point): base(X_coor, Y_coor, name, description)
        {
            this.highest_point = highest_point;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Highest point: {highest_point}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            River river = new River(120, 214, "Dnipro", "The longest river in Ukraine", 25.5, 5000);
            Mountain mountain = new Mountain(345, 654, "Hoverla", "The highest mountain in Ukraine", 2000);
            Console.Write("Object river:\n");
            river.GetInformation();
            Console.WriteLine("\n");
            Console.Write("Object mountain:\n");
            mountain.GetInformation();
            Console.ReadKey(true);
        }
    }
}
