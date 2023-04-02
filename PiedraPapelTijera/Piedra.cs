namespace PiedraPapelTijera
{
    public class Piedra : ElementoBase
    {
        public Piedra()
        {
            Tipo = "Piedra";
        }
        public override string ResultadoContra(ElementoBase e)
        {
            string result;

            if (e.Tipo == "Tijera")
                result = "gana";
            else if (e.Tipo == "Piedra")
                result = "empata";
            else
                result = "pierde";

            return result;
        }
    }
}
