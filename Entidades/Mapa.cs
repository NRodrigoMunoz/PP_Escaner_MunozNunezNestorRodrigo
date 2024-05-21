using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        //Atributos
        int alto;
        int ancho;

        //Propiedades
        public int Alto { get => alto;}
        public int Ancho { get => ancho;}
        public int Superficie { get => ancho * alto;}

        //Constructor
        public Mapa(string titulo, string autor, int anio, string numNormalizado, string codebar,int ancho,int alto)
            : base(titulo, autor, anio, numNormalizado , codebar)
        {
           this.ancho = ancho;
           this.alto = alto;
        }

        /// <summary>
        /// Operador de igualdad se utiliza para diferencias un Libro de otro utilizando sus atributos tomados por su propiedad por medio de un get
        /// se compara su barcode o titulo, autor, año y la superfice
        /// </summary>
        /// <param name="m1">Primer mapa a comparar</param>
        /// <param name="m2">Segundo mapa a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Mapa m1,Mapa m2)
        {
            return m1.Barcode == m2.Barcode || m1.Titulo == m2.Titulo && m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie;
        }

        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1.Barcode == m2.Barcode || m1.Titulo == m2.Titulo && m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie);
        }

        /// <summary>
        /// Devuelve la informacion de un mapa (Titulo,Auto,Año,Cód. de barras y Superficie)
        /// mediante sus propiedades utilizando el metodo override ToString utilizando la clase StringBuilder.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.Titulo}");
            sb.AppendLine($"Autor: {this.Autor}");
            sb.AppendLine($"Año: {this.Anio}");
            sb.AppendLine($"Cód. de barras: {this.Barcode}");
            sb.AppendLine($"Superficie: {this.alto} * {this.ancho} = {this.Superficie} cm2.");
            return sb.ToString();
        }
    }
}
