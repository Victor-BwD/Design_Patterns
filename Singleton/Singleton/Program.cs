Singleton.Singleton jogador_1 = Singleton.Singleton.GetInstance;
jogador_1.Mensagem("Jogador 1: A bola está comigo no meio campo.");

Singleton.Singleton jogador_2 = Singleton.Singleton.GetInstance;
jogador_2.Mensagem("Jogador 2: Recebeu a bola");

Singleton.Singleton jogador_3 = Singleton.Singleton.GetInstance;
jogador_3.Mensagem("Jogador 3: Recebeu o lançamento na linha de fundo.");

Console.ReadKey();
