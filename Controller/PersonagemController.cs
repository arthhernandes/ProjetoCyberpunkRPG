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
            _visao.MostrarMensagem("=== SISTEMA DE CRIAÇÃO MVC ===");

            string nome = _visao.ObterEntrada("Digite o nome do personagem: ");

            ClassePersonagem classeEscolhida = EscolherClasseMenu();

            IEstrategiaGeracaoAtributos estrategia = EscolherEstrategiaMenu();

            Personagem novoPersonagem = new Personagem(nome, estrategia, classeEscolhida);

            _visao.MostrarMensagem("\n[ Personagem criado com sucesso! ]");
            _visao.ExibirFichaPersonagem(novoPersonagem);
        }

        private ClassePersonagem EscolherClasseMenu()
        {
            _visao.MostrarMensagem("\n[ ESCOLHA A CLASSE (ROTA PROFISSIONAL) ]");
            _visao.MostrarMensagem("1 - Mercenário (Solo)");
            _visao.MostrarMensagem("2 - Hacker (Netrunner)");
            _visao.MostrarMensagem("3 - Samurai de Rua");
            _visao.MostrarMensagem("4 - Atravessador (Fixer)");

            while (true)
            {
                string opcao = _visao.ObterEntrada("Digite o número da classe: ");
                switch (opcao)
                {
                    case "1": return new Mercenario();
                    case "2": return new Hacker();
                    case "3": return new SamuraiDeRua();
                    case "4": return new Atravessador();
                    default: _visao.MostrarMensagem("Opção inválida. Tente novamente."); break;
                }
            }
        }

        private IEstrategiaGeracaoAtributos EscolherEstrategiaMenu()
        {
            _visao.MostrarMensagem("\n[ ESCOLHA A FORMA DE ATRIBUTOS ]");
            _visao.MostrarMensagem("1 - Forma Clássica (3d6 na ordem)");
            _visao.MostrarMensagem("2 - Forma Livre (3d6, você distribui)");
            _visao.MostrarMensagem("3 - Forma Heróica (4d6, descarta o menor)");

            while (true)
            {
                string opcao = _visao.ObterEntrada("Digite o número da forma de distribuição: ");
                switch (opcao)
                {
                    case "1":
                        _visao.MostrarMensagem("\n[Iniciando Forma 1: Clássica]");
                        return new EstrategiaClassica();
                    case "2":
                        _visao.MostrarMensagem("\n[Iniciando Forma 2: Distribuição Livre]");
                        return new EstrategiaLivre(_visao);
                    case "3":
                        _visao.MostrarMensagem("\n[Iniciando Forma 3: Heróica]");
                        return new EstrategiaHeroica();
                    default:
                        _visao.MostrarMensagem("Opção inválida. Tente novamente."); break;
                }
            }
        }
    }
}