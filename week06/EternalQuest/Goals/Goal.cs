
// Provide for simple goals that can be marked complete and the user gains some value.
// For example, if you run a marathon you get 1000 points.


// Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
// For example, every time you read your scriptures you get 100 points.


// Provide for a checklist goal that must be accomplished a certain number of times to be complete. 
//Each time the user records this goal they gain some value, but when they achieve the desired amount, 
//they get an extra bonus.
// For example, if you set a goal to attend the temple 10 times,
// you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.

using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;  // Keep as string

    public Goal(string name, string description, string points)
    {
        this._shortName = name;
        this._description = description;
        this._points = points;
    }

    public abstract void RecordEvent();
    public abstract bool isCompleted();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}