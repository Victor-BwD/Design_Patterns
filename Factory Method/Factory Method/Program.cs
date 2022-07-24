using Factory_Method;

Factory_Method.FactoryMethod factory = new Factory_Method.FactoryMethod();

Console.WriteLine("Liu	Kang	|	SubZero	|	Scorpion");
Console.WriteLine();

Console.Write("Escolha	seu	Personagem:	");
string escolha = Console.ReadLine();

IPersonagem personagem = factory.EscolherPersonagem(escolha);
Console.WriteLine();
Console.Write("Você vai jogar com: ");
personagem.Escolhido();

Console.ReadKey();