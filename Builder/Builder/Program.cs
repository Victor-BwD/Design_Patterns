var exercito = new Builder.Exercito();
Builder.CriadorDeSoldado criadorDeSoldado;
Builder.Soldado soldado;

// Criando um soldado das Forças Especiais
criadorDeSoldado = new Builder.CriadorForcasEspeciais();
exercito.ConstruirSoldado(criadorDeSoldado);
soldado = criadorDeSoldado.ObterSoldado();
Console.WriteLine("Soldado com as características: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);
Console.ReadKey();
