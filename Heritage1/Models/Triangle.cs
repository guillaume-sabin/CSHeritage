using System;
using System.Text;

namespace Heritage1
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double Air => Math.Sqrt(this.Perimetre * (this.Perimetre - this.A) * (this.Perimetre - this.B) * (this.Perimetre - this.C));
        public override double Perimetre => this.A + this.B + this.C;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Triangle de Cotes {this.A} {this.B} {this.C}\n\r")
                .Append(base.ToString());

            return sb.ToString();
        }
    }
}