using System.Text;
using Poo.Interfaces;

namespace Poo.Models;

internal class SuperHero : Hero, ISuperHero
{
    private string _Name = string.Empty;
    public int Id { get; set; }
    public override string Name
    {
        get { return _Name; }
        set { _Name = value.Trim(); }
    }

    public string NameAndSecretIdentity
    {
        get { return $"{Name} ({SecretIdentity})"; }
    }

    public string SecretIdentity { get; set; }
    public string City;
    public List<SuperPower> SuperPowers = new();
    public bool CanFly;

    // public SuperHero(int id, string name, string secretIdentity, string city, bool canFly)
    public SuperHero()
    {
        Id = 1;
        SuperPowers = new List<SuperPower>();
        CanFly = false;
    }

    public string UseSuperPowers()
    {
        StringBuilder sb = new();
        foreach (SuperPower superPower in SuperPowers)
        {
            sb.AppendLine($"{NameAndSecretIdentity} is using the super power {superPower.Name}");
        }
        return sb.ToString();
    }

    public override string SaveTheWorld()
    {
        return $"{NameAndSecretIdentity} saved the world \n";
    }

    public override string SaveTheEarth()
    {
        // return base.SaveTheEarth();
        return $"{NameAndSecretIdentity} saved the earth \n";
    }
}