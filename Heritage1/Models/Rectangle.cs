
using System.Text;

namespace Heritage1
{
    public class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Air => this.Longueur * this.Largeur;

        public override double Perimetre => (this.Longueur + this.Largeur) * 2;
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Rectangle de Longueur {this.Longueur} et largeur {this.Largeur}\n\r")
                .Append(base.ToString());

            return sb.ToString();
        }
    }
}