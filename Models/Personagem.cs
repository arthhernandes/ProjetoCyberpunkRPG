namespace ProjetoCyberpunRPG.Models
{
    public class Personagem
    {
        public string Nome { get; private set; }
        public Atributos Atributos { get; private set; }
        public ClassePersonagem Classe { get; private set; }
        public int PVMaximo { get; private set; }

        public Personagem(string nome, IEstrategiaGeracaoAtributos estrategiaStatus, ClassePersonagem classe)
        {
            Nome = nome;
            Classe = classe;
            Atributos = estrategiaStatus.Gerar(); 
            
            int modCon = Atributos.ObterModificador(Atributos.Constituicao);
            PVMaximo = Classe.CalcularPVIniciais(modCon);
        }
    }
}