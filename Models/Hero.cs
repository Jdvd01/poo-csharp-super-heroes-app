namespace Poo.Models;

internal abstract class Hero
{
    public abstract string Name { get; set; }
    public abstract string SaveTheWorld();

    public virtual string SaveTheEarth()
    {
        return $"{Name} saved the earth \n";
    }
}