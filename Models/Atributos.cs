namespace ProjetoCyberpunkRPG.Models
{
    public class Atributos
    {
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }

        public static int ObterModificador(int valor)
        {
            if (valor <= 3) return -3;
            if (valor <= 5) return -2;
            if (valor <= 8) return -1;
            if (valor <= 12) return 0;
            if (valor <= 15) return 1;
            if (valor <= 17) return 2;
            return 3;
        }
    }
}