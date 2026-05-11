using System.Collections.Generic;

namespace ProjetoCyberpunRPG.Models
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

    public class HomemDeArmas : ClassePersonagem
    {
        public override string Nome => "Homem de Armas";
        public override string Descricao => "Guerreiros treinados nas artes do combate.";
        public override int DadoDeVida => 10;
        public override List<string> Caracteristicas => new List<string> { "Uso de todas as armas e armaduras", "Especialização em Armas" };
    }

    public class Mago : ClassePersonagem
    {
        public override string Nome => "Mago";
        public override string Descricao => "Estudiosos dos arcanos, portadores de magias.";
        public override int DadoDeVida => 4;
        public override List<string> Caracteristicas => new List<string> { "Lançamento de Magias Arcanas", "Restrição de Armaduras pesadas" };
    }

    public class Ladrao : ClassePersonagem
    {
        public override string Nome => "Ladrão";
        public override string Descricao => "Especialistas em furtividade e armadilhas.";
        public override int DadoDeVida => 6;
        public override List<string> Caracteristicas => new List<string> { "Ataque Furtivo", "Desarmar Armadilhas" };
    }

    public class Clerigo : ClassePersonagem
    {
        public override string Nome => "Clérigo";
        public override string Descricao => "Sacerdotes devotos que canalizam poder divino.";
        public override int DadoDeVida => 8;
        public override List<string> Caracteristicas => new List<string> { "Magias Divinas", "Afastar Mortos-Vivos" };
    }
}