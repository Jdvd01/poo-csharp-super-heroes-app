using Poo.Interfaces;

namespace Poo;

internal class PrintInfo
{
    public void PrintSuperHero(ISuperHero superHero)
    {
        Console.WriteLine($"Id: {superHero.Id}");
        Console.WriteLine($"Name: {superHero.Name}");
        Console.WriteLine($"SecretIdentity: {superHero.SecretIdentity}");
    }
}