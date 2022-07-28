Abstract_Factory.IFabricaBases fabrica;

Console.WriteLine("Escolha um dos personagens: 1-Protoss | 2-Zergs | 3-Terranos");

switch (Console.ReadLine())
{
    case "1":
        fabrica = new Abstract_Factory.FabricaBaseProtoss();
        break;
    case "2":
        fabrica = new Abstract_Factory.FabricaBaseZerg();
        break;
    case "3":
        fabrica = new Abstract_Factory.FabricaBaseTerran();
        break;
}
Console.ReadLine();