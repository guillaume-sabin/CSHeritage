using System;
using System.Text;

namespace Heritage1
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Air => Math.PI * (this.Rayon * this.Rayon);

        public override double Perimetre => this.Rayon * 2 * Math.PI;
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Cercle de Rayon {this.Rayon}\n\r")
                .Append(base.ToString());

            return sb.ToString();
        }
    }
}