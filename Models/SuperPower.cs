namespace Poo.Models;

public class SuperPower
{
    public string Name;
    public string? Description;
    public PowerLevel Level = PowerLevel.LevelOne;

    public SuperPower(string name, PowerLevel level)
    {
        Name = name;
        Level = level;
    }
}


public enum PowerLevel {
    LevelOne,
    LevelTwo,
    LevelThree
}