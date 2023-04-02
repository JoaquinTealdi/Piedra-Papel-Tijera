namespace PiedraPapelTijera
{
    public abstract class ElementoBase
    {
        public string Tipo { get; set; }

        public ElementoBase(string tipo)
        {
            Tipo = tipo;
        }
        public ElementoBase() { }
        public virtual string ResultadoContra(ElementoBase e)
        {
            return "";
        }
    }
}
