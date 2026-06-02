using System;
using System.Collections.Generic;
using ProjetoCyberpunkRPG.Models;

namespace ProjetoCyberpunRPG.View
{
    public class ViewConsole : IAtribuidorDeValores
    {
        public void MostrarMensagem(string mensagem) => Console.WriteLine(mensagem);

        public string ObterEntrada(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public int AtribuirValor(string nomeAtributo, List<int> rolagensDisponiveis)
        {
            int valorEscolhido = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write($"Valores restantes [{string.Join(", ", rolagensDisponiveis)}]. Valor para {nomeAtributo}: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out valorEscolhido) && rolagensDisponiveis.Contains(valorEscolhido))
                {
                    rolagensDisponiveis.Remove(valorEscolhido);
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Erro: Escolha um número válido da lista.\n");
                }
            }
            return valorEscolhido;
        }

        public void ExibirFichaPersonagem(Personagem personagem)
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine($"Nome: {personagem.Nome} | Classe: {personagem.Classe.Nome}");
            Console.WriteLine($"PV Máximos: {personagem.PVMaximo} (Dado: d{personagem.Classe.DadoDeVida})");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"FOR: {personagem.Atributos.Forca} ({Atributos.ObterModificador(personagem.Atributos.Forca):+0;-#}) | " +
                              $"DES: {personagem.Atributos.Destreza} ({Atributos.ObterModificador(personagem.Atributos.Destreza):+0;-#}) | " +
                              $"CON: {personagem.Atributos.Constituicao} ({Atributos.ObterModificador(personagem.Atributos.Constituicao):+0;-#})");
            Console.WriteLine($"INT: {personagem.Atributos.Inteligencia} ({Atributos.ObterModificador(personagem.Atributos.Inteligencia):+0;-#}) | " +
                              $"SAB: {personagem.Atributos.Sabedoria} ({Atributos.ObterModificador(personagem.Atributos.Sabedoria):+0;-#}) | " +
                              $"CAR: {personagem.Atributos.Carisma} ({Atributos.ObterModificador(personagem.Atributos.Carisma):+0;-#})");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Descrição: {personagem.Classe.Descricao}");
            Console.WriteLine("Características: " + string.Join(", ", personagem.Classe.Caracteristicas));
            Console.WriteLine("====================================\n");
        }
    }
}