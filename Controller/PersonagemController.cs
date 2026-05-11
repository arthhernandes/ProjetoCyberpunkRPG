using ProjetoCyberpunRPG.Models;
using ProjetoCyberpunRPG.View;

namespace ProjetoCyberpunRPG.Controller
{
    public class PersonagemController
    {
        private readonly ViewConsole _visao;

        public PersonagemController(ViewConsole visao)
        {
            _visao = visao;
        }

        public void IniciarProcessoCriacao()
        {
            _visao.MostrarMensagem("=== SISTEMA DE CRIAÇÃO MVC - OLD DRAGON ===");
            
            string nome = _visao.ObterEntrada("Digite o nome do personagem: ");
            
            ClassePersonagem classeEscolhida = new HomemDeArmas(); 
            
            _visao.MostrarMensagem("\n[Iniciando Forma 2: Distribuição Livre]");
            
            IEstrategiaGeracaoAtributos estrategia = new EstrategiaLivre(_visao);

            Personagem novoPersonagem = new Personagem(nome, estrategia, classeEscolhida);

            _visao.MostrarMensagem("\n[ Personagem criado com sucesso! ]");
            _visao.ExibirFichaPersonagem(novoPersonagem);
        }
    }
}