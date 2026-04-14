using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    protected Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date => _date;
    public int lengthMinutes => _lengthMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({lengthMinutes} min) -" +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kmh, Pace {GetPace():0.00} min per km";
    }
}
    
    

 
