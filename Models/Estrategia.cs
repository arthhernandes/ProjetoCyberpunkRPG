using System.Collections.Generic;
using System.Linq;

namespace ProjetoCyberpunRPG.Models
{
    public class EstrategiaClassica : IEstrategiaGeracaoAtributos
    {
        public Atributos Gerar() => new Atributos
        {
            Forca = Dado.Rolar(3, 6), Destreza = Dado.Rolar(3, 6),
            Constituicao = Dado.Rolar(3, 6), Inteligencia = Dado.Rolar(3, 6),
            Sabedoria = Dado.Rolar(3, 6), Carisma = Dado.Rolar(3, 6)
        };
    }

    public class EstrategiaLivre : IEstrategiaGeracaoAtributos
    {
        private readonly IAtribuidorDeValores _atribuidor;

        public EstrategiaLivre(IAtribuidorDeValores atribuidor)
        {
            _atribuidor = atribuidor;
        }

        public Atributos Gerar()
        {
            List<int> rolagens = Enumerable.Range(0, 6).Select(_ => Dado.Rolar(3, 6)).OrderByDescending(x => x).ToList();

            return new Atributos
            {
                Forca = _atribuidor.AtribuirValor("FORÇA", rolagens),
                Destreza = _atribuidor.AtribuirValor("DESTREZA", rolagens),
                Constituicao = _atribuidor.AtribuirValor("CONSTITUIÇÃO", rolagens),
                Inteligencia = _atribuidor.AtribuirValor("INTELIGÊNCIA", rolagens),
                Sabedoria = _atribuidor.AtribuirValor("SABEDORIA", rolagens),
                Carisma = _atribuidor.AtribuirValor("CARISMA", rolagens)
            };
        }
    }

    public class EstrategiaHeroica : IEstrategiaGeracaoAtributos
    {
        public Atributos Gerar() => new Atributos
        {
            Forca = Dado.Rolar4d6DescartarMenor(), Destreza = Dado.Rolar4d6DescartarMenor(),
            Constituicao = Dado.Rolar4d6DescartarMenor(), Inteligencia = Dado.Rolar4d6DescartarMenor(),
            Sabedoria = Dado.Rolar4d6DescartarMenor(), Carisma = Dado.Rolar4d6DescartarMenor()
        };
    }
}