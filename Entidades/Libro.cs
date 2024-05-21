using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        //Atributo
        int numPaginas;
       
        //Propiedades
        public int NumPaginas { get => numPaginas;}
        public string ISBN { get => this.NumNormalizado; }

        //Constructor
        public Libro(string titulo,string autor, int anio, string numNormalizado,string codebar,int numPaginas)
            :base(titulo,autor,anio, numNormalizado,codebar)
        {
            this.numPaginas = numPaginas;
        }


        /// <summary>
        /// Operador de igualdad se utiliza para diferencias un Libro de otro utilizando sus atributos tomados por su propiedad por medio de un get
        /// se compara su barcode o ISBN o su titulo y autor
        /// </summary>
        /// <param name="l1">Primer libro a comparar</param>
        /// <param name="l2">Segundo libro a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Libro l1, Libro l2)
        {
            return l1.Barcode == l2.Barcode || l1.ISBN == l2.ISBN || l1.Titulo == l2.Titulo && l1.Autor == l2.Autor;
        }

        /// <summary>
        /// Sobrecarga del operador == 
        /// </summary>
        /// <param name="l1">Primer libro a comparar</param>
        /// <param name="l2">Primer libro a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1.Barcode == l2.Barcode || l1.ISBN == l2.ISBN || l1.Titulo == l2.Titulo && l1.Autor == l2.Autor);
        }

        /// <summary>
        /// Devuelve la informacion de un libro (Titulo,Autor,Año,ISBN,Cód. de barras y Número de páginas)
        /// mediante sus propiedades utilizando el metodo override ToString utilizando la clase StringBuilder.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.Titulo}");
            sb.AppendLine($"Autor: {this.Autor}");
            sb.AppendLine($"Año: {this.Anio}");
            sb.AppendLine($"ISBN: {this.ISBN}");
            sb.AppendLine($"Cód. de barras: {this.Barcode}");
            sb.AppendLine($"Número de páginas: {this.NumPaginas}.");
            return sb.ToString();
        }
    }
}
