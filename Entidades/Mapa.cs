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
        public static bool operator ==(Mapa m1,Mapa m2)
        {
            return m1.Barcode == m2.Barcode || m1.Titulo == m2.Titulo && m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie;
        }

        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1 == m2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\n{base.ToString()}");
            sb.AppendLine($"Superficie: {this.alto} * {this.ancho} = {this.Superficie} cm2.");
            return sb.ToString();
            
        }
    }
}
