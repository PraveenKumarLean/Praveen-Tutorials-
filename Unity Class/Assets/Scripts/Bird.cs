using UnityEngine;

public class Bird 
{ 
    public string Name;
    public float Speed;
    public int eatingInKG;
}

public class Eagle : Bird
{
    public string hunt;
    public void EagleProperties()
    {
        Name = "Eagle";
    }

    public void fly()
    {

    }

    public void eat()
    {

    }
}

public class Hean : Bird
{

    public void HeanProperties()
    {
        Name = "Hean";
    }

    public void fly()
    {
        
    }
}
