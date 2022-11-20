// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DZ_Bridge_Pattern_BuildingCompany_3;

WallCreator wallCreator = new CityBuildingCompany(new BrickWallsCommand());

Console.WriteLine(nameof(CityBuildingCompany).ToUpper() + "\n");
wallCreator.DoWork();
Console.WriteLine("-------------------------------------------");
Console.WriteLine(nameof(CityBuildingCompany).ToUpper() + "\n");
wallCreator = new CityBuildingCompany(new ConcreteWallsCommand());
wallCreator.DoWork();
Console.WriteLine("-------------------------------------------");

Console.WriteLine(nameof(MountainsBuildingCompany).ToUpper() + "\n");
wallCreator = new MountainsBuildingCompany(new BrickWallsCommand());
wallCreator.DoWork();
Console.WriteLine("-------------------------------------------");
Console.WriteLine(nameof(MountainsBuildingCompany).ToUpper() + "\n");
wallCreator = new MountainsBuildingCompany(new ConcreteWallsCommand());
wallCreator.DoWork();
Console.WriteLine("-------------------------------------------");

Console.WriteLine(nameof(NearSeeBuildingCompany).ToUpper() + "\n");
wallCreator = new NearSeeBuildingCompany(new BrickWallsCommand());
wallCreator.DoWork();
Console.WriteLine("-------------------------------------------");
Console.WriteLine(nameof(NearSeeBuildingCompany).ToUpper() + "\n");
wallCreator = new NearSeeBuildingCompany(new ConcreteWallsCommand());
wallCreator.DoWork();