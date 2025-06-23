using Poo;
using Poo.Models;

PrintInfo printInfo = new();

// SuperHero superMan = new SuperHero(1, "   Superman   ", "Clark Kent", "Metropolis", true);
SuperHero superMan = new SuperHero();
superMan.Id = 1;
superMan.Name = "  Superman     ";
superMan.SecretIdentity = "Clark Kent";
superMan.City = "Metropolis";
superMan.CanFly = true;

// SuperHero ironMan = new SuperHero(2, "Ironman", "Tony Stark", "New York", true);
SuperHero ironMan = new SuperHero();
ironMan.Id = 2;
ironMan.Name = "Ironman";
ironMan.SecretIdentity = "Tony Stark";
ironMan.City = "New York";
ironMan.CanFly = true;

SuperPower superStrength = new("Super strength", PowerLevel.LevelThree);
SuperPower XRayVision = new("X-Ray vision", PowerLevel.LevelTwo);
SuperPower regeneration = new("Regeneration", PowerLevel.LevelThree);

superMan.SuperPowers.Add(superStrength);
superMan.SuperPowers.Add(XRayVision);

Console.WriteLine(superMan.UseSuperPowers());
Console.WriteLine(superMan.SaveTheWorld());


AntiHero wolverine = new();
wolverine.Id = 3;
wolverine.Name = "Wolverine";
wolverine.SecretIdentity = "Logan";
wolverine.SuperPowers = [regeneration, superStrength];
Console.WriteLine(wolverine.UseSuperPowers());
Console.WriteLine(wolverine.PerformAntiHeroAction("Attack the police"));

Console.WriteLine(wolverine.SaveTheEarth());

printInfo.PrintSuperHero(wolverine);
Console.WriteLine("================"); 
printInfo.PrintSuperHero(superMan);