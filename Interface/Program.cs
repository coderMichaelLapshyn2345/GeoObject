public interface Geographical_Object
{
    public double X { get; set; }

    public double Y { get; set; }
    public string name { get; set; }
    public string des { get; set; }

    public void GetInformation();

}
class River : Geographical_Object
{
    private double x;
    private double y;
    private string Name;
    private string Des;
    private double speed;
    private double len;
    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public string name { get => Name; set => Name = value; }
    public string des { get => Des; set => Des = value; }

    public double Speed { get => speed; set => speed = value; }
    public double Len { get => len; set => len = value; }

    public void GetInformation()
    {
        Console.Write($"X: {X}\nY: {Y}\nName: {name}\nDescription: {des}\nSpeed: {speed}\nLength: {len}");
    }
}
class Mountain : Geographical_Object
{
    private double x_coor;
    private double y_coor;
    private string _name;
    private string _des;
    private double highest_point;

    public double X { get => x_coor; set => x_coor = value; }
    public double Y { get => y_coor; set => y_coor = value; }

    public string name { get => _name; set => _name = value; }

    public string des { get => _des; set => _des = value; }

    public double Highest { get => highest_point; set => highest_point = value; }

    public void GetInformation()
    {
        Console.Write($"X: {X}\nY: {Y}\nName: {name}\nDescription: {des}\nHighest point: {Highest}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        River river = new River(); // object river;
        Mountain mountain = new Mountain(); // object mountain 

        // Setting values to the river object
        river.name = "Dnipro";
        river.Speed = 50;
        river.X = 110;
        river.Y = 60;
        river.Len = 5000;
        river.des = "The longest river in Ukraine";

        // Setting values to the mountain object 
        mountain.name = "Hoverla";
        mountain.Highest = 2000;
        mountain.X = 136;
        mountain.Y = 111;
        mountain.des = "The highest mountain in Ukraine, which is located in Carpathian";

        // Print information about object river
        Console.Write("River:\n");
        river.GetInformation();
        Console.WriteLine("\n");

        Console.WriteLine("Mountain:");
        // Print information about object mountain
        mountain.GetInformation();
    }
}