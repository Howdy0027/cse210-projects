// Cycling class inheriting from Activity
public class Cycling : Activity
{
    // Private member variable to store the speed (in mph)
    private double speed;

    // Constructor to initialize the cycling activity
    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        this.speed = speed;
    }

    // Override methods to return distance, speed, and pace
    public override double GetDistance() => (speed * Length) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}