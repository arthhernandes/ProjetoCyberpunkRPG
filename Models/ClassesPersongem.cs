using System.Collections.Generic;

namespace ProjetoCyberpunkRPG.Models
{
    public abstract class ClassePersonagem
    {
        public abstract string Nome { get; }
        public abstract string Descricao { get; }
        public abstract List<string> Caracteristicas { get; }
        public abstract int DadoDeVida { get; }

        public int CalcularPVIniciais(int modificadorConstituicao)
        {
            int pv = DadoDeVida + modificadorConstituicao;
            return pv < 1 ? 1 : pv; 
        }
    }

    public class Mercenario : ClassePersonagem
    {
        public override string Nome => "Mercenário (Solo)";
        public override string Descricao => "Especialistas em combate e segurança armada.";
        public override int DadoDeVida => 10; 
        public override List<string> Caracteristicas => new List<string> { "Sub-Derme Balística", "Proficiência com Armas Pesadas" };
    }

    public class Hacker : ClassePersonagem
    {
        public override string Nome => "Hacker (Netrunner)";
        public override string Descricao => "Capazes de fritar sistemas corporativos a distância.";
        public override int DadoDeVida => 4;
        public override List<string> Caracteristicas => new List<string> { "Cyberdeck Neural Integrado", "Invasão de Sistemas" };
    }

    public class SamuraiDeRua : ClassePersonagem
    {
        public override string Nome => "Samurai de Rua";
        public override string Descricao => "Assassinos com implantes focados em reflexos e lâminas.";
        public override int DadoDeVida => 8;
        public override List<string> Caracteristicas => new List<string> { "Lâminas Mantis Embutidas", "Acelerador Sináptico" };
    }

    public class Atravessador : ClassePersonagem
    {
        public override string Nome => "Atravessador (Fixer)";
        public override string Descricao => "Contrabandistas e negociantes do submundo.";
        public override int DadoDeVida => 6;
        public override List<string> Caracteristicas => new List<string> { "Acesso à Rede de Contrabando", "Lábia Aprimorada" };
    }
}