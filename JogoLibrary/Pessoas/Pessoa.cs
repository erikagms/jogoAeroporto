namespace JogoLibrary.Pessoas
{
    public abstract class Pessoa
    {
        public bool Dirige { get; set; }
        public bool Tripulante { get; set; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}