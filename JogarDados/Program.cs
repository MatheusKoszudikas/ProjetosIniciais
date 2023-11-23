using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("### Jogo de Dados ###");

        string nomeJogador1, nomeJogador2;
        do
        {
            Console.Write("Nome do primeiro jogador: ");
            nomeJogador1 = Console.ReadLine();

            Console.Write("Nome do segundo jogador: ");
            nomeJogador2 = Console.ReadLine();

            if (nomeJogador1 == nomeJogador2)
            {
                Console.WriteLine("Os nomes dos jogadores não podem ser iguais. Tente novamente.");
            }

        } while (nomeJogador1 == nomeJogador2);


        int pontosJogador1 = 0, pontosJogador2 = 0;

        for (int rodada = 1; rodada <= 3; rodada++)
        {
            Console.WriteLine($"\n### Rodada {rodada} ###");

            int resultadoJogador1 = JogarDados(nomeJogador1);
            int resultadoJogador2 = JogarDados(nomeJogador2);

            Console.WriteLine($"{nomeJogador1} tirou o número {resultadoJogador1} e {nomeJogador2} tirou o número {resultadoJogador2}.");

            if (resultadoJogador1 > resultadoJogador2)
            {
                Console.WriteLine($"{nomeJogador1} venceu a rodada {rodada}!");
                pontosJogador1++;
            }
            else if (resultadoJogador2 > resultadoJogador1)
            {
                Console.WriteLine($"{nomeJogador2} venceu a rodada {rodada}!");
                pontosJogador2++;
            }
            else
            {
                Console.WriteLine("Empate na rodada.");
            }

            Console.WriteLine($"Pontos do jogador {nomeJogador1}: {pontosJogador1}");

            Console.WriteLine($"Pontos do jogador {nomeJogador2}: {pontosJogador2}");
        }
        if (pontosJogador1 > pontosJogador2)
        {
            Console.WriteLine($"\n{nomeJogador1} é o vencedor!");
        }
        else if (pontosJogador2 > pontosJogador1)
        {
            Console.WriteLine($"\n{nomeJogador2} é o vencedor!");
        }
        else
        {
            Console.WriteLine("\nO jogo terminou em empate!");
        }

        Console.ReadLine();
    }

    static int JogarDados(string nomeJogador)
    {
        Console.WriteLine($"{nomeJogador}, pressione Enter para jogar os dados...");
        Console.ReadLine();

        Random random = new Random();
        return random.Next(1, 7);
    }
}
