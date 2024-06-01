using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoIncorrectoException : Exception
    {
        //Atributos
        string nombreClase;
        string nombreMetodo;

        //Propiedades
        public string NombreClase { get => nombreClase; }
        public string NombreMetodo { get => nombreMetodo; }

        public TipoIncorrectoException(string mensaje, string nombreClase, string nombreMetodo)
        : base(mensaje)
        {
            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;
        }

        public TipoIncorrectoException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepción en el método {NombreMetodo} de la clase {NombreClase}.");
            sb.AppendLine("Algo salió mal, revisa los detalles");
            sb.AppendLine($"Detalles: {base.Message}");
            return sb.ToString();
        }
    }
}
