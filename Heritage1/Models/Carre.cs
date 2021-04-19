using System.Text;

namespace Heritage1
{
    public class Carre : Forme
    {
        public int Longueur { get; set; }

        public override double Air => this.Longueur * this.Longueur;
        public override double Perimetre => this.Longueur * 4;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Carré de Longueur {this.Longueur}\n\r")
                .Append(base.ToString());

            return sb.ToString();
        }
    }
}