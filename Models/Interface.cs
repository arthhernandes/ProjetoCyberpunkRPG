using System.Collections.Generic;

namespace ProjetoCyberpunRPG.Models
{
    public interface IAtribuidorDeValores
    {
        int AtribuirValor(string nomeAtributo, List<int> rolagensDisponiveis);
    }

    public interface IEstrategiaGeracaoAtributos
    {
        Atributos Gerar();
    }
}