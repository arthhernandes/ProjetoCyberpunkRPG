using ProjetoCyberpunRPG.View;
using ProjetoCyberpunRPG.Controller;
using ProjetoCyberpunkRPG.Data;

namespace ProjetoCyberpunRPG
{
    class Program
    {
        static void Main(string[] args)


        {
            

            var visao = new ViewConsole();
            var controlador = new PersonagemController(visao);

            controlador.IniciarProcessoCriacao();

            using var db = new CyberpunkContext();

            var personagens = db.Personagens.ToList();

            foreach (var p in personagens)
            {
                Console.WriteLine($"{p.Nome} - {p.ClasseNome} - PV: {p.PVMaximo}");
            }
        }
    }
}