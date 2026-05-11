using ProjetoCyberpunRPG.View;
using ProjetoCyberpunRPG.Controller;

namespace ProjetoCyberpunRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var visao = new ViewConsole();
            var controlador = new PersonagemController(visao);
            
            controlador.IniciarProcessoCriacao();
        }
    }
}