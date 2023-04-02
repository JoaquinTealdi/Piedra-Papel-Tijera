namespace PiedraPapelTijera
{
    public class Papel : ElementoBase
    {
        public Papel()
        {
            Tipo =  "Papel";
        }
        public override string ResultadoContra(ElementoBase e)
        {
            string result;

            if (e.Tipo == "Tijera")
                result = "pierde";
            else if (e.Tipo == "Piedra")
                result = "gana";
            else
                result = "empata";

            return result;
        }
    }
}
