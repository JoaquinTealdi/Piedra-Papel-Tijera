namespace PiedraPapelTijera
{
    public class Tijera : ElementoBase
    {
        public Tijera()
        {
            Tipo = "Tijera";
        }
        public override string ResultadoContra(ElementoBase e)
        {
            string result;

            if (e.Tipo == "Tijera")
                result = "empata";
            else if(e.Tipo == "Piedra")
                result = "pierde";
            else
                result = "gana";

            return result;
        }
    }
}
