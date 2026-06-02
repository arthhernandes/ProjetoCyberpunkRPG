namespace ProjetoCyberpunkRPG.Models
{
    public class Personagem
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Atributos Atributos { get; private set; }
        public ClassePersonagem Classe { get; private set; }
        public int PVMaximo { get; private set; }
        public string ClasseNome { get; private set; }

        private Personagem()
        {
        }

        public Personagem(string nome, IEstrategiaGeracaoAtributos estrategiaStatus, ClassePersonagem classe)
        {
            Nome = nome;
            Classe = classe;
            ClasseNome = classe.Nome;
            Atributos = estrategiaStatus.Gerar();

            int modCon = Atributos.ObterModificador(Atributos.Constituicao);
            PVMaximo = Classe.CalcularPVIniciais(modCon);
        }
    }
}