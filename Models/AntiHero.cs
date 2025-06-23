namespace Poo.Models;

internal class AntiHero : SuperHero
{
    public string PerformAntiHeroAction(string action)
    {
        return $"The AntiHero {NameAndSecretIdentity} has made: {action} \n";
    }
}