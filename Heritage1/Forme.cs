using System.Text;

namespace Heritage1
{
    public abstract class Forme
    {
        public virtual double Air { get; }
        public virtual double Perimetre { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Air = {this.Air}\n\r")
                .Append($"Perimetre = {this.Perimetre}");

            return sb.ToString();
        }
    }
}