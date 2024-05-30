using System.Text;

namespace Entidades
{
    public abstract class Documento
    {
        //Atributos
        int anio;
        string autor;
        string barcode;
        Paso estado;
        private string numNormalizado;
        string titulo;

        //Propiedades
        public int Anio { get => anio;}
        public string Autor { get => autor;}
        public string Barcode { get => barcode;}
        public Paso Estado { get => estado;}
        protected string NumNormalizado { get => numNormalizado;}
        public string Titulo { get => titulo;}

        public Documento(string titulo,string autor,int anio,string numNormalizado,string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.barcode = barcode;
            this.numNormalizado = numNormalizado;
            this.estado = Paso.Inicio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Autor: {this.Autor}");
            sb.AppendLine($"Año: {this.Anio}");
            if (NumNormalizado.Length > 1 ) 
            {
                    sb.AppendLine($"ISBN: {this.NumNormalizado}");
            }
            sb.AppendLine($"Cód de barras: {this.Barcode}");
            return sb.ToString();
        }

        public bool AvanzarEstado()
        {
            if(this.estado == Paso.Terminado)
            {
                return false;
            }
            else
            {
                this.estado++;
                return true;
            }
        }

        public enum Paso
        {
            Inicio,
            Distruibuido,
            EnEscaner,
            EnRevision,
            Terminado
        }
    }
}
