using System;
using System.Linq;

namespace ProjetoCyberpunRPG.Models
{
    public class Dado
    {        
        private static readonly Random gerador = new Random();
        
        public static int Rolar(int quantidade, int faces) => 
            Enumerable.Range(0, quantidade).Sum(_ => gerador.Next(1, faces + 1));
        
        public static int Rolar4d6DescartarMenor() => 
            Enumerable.Range(0, 4).Select(_ => gerador.Next(1, 7)).OrderBy(x => x).Skip(1).Sum();
    }  
}