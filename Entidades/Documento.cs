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


        /// <summary>
        /// Constructor de la clase padre documento para completar los atributos de sus clases hijas Mapa/Libro
        /// esta misma no se puede instanciar por ser abstracta y tanto como Mapa o libro que se instancie tendra por defecto
        /// su estado en Inicio.
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="anio"></param>
        /// <param name="numNormalizado"></param>
        /// <param name="barcode"></param>
        public Documento(string titulo,string autor,int anio,string numNormalizado,string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.barcode = barcode;
            this.numNormalizado = numNormalizado;
            this.estado = Paso.Inicio;
        }
        
        /// <summary>
        /// Se utiliza para brindar la informacion de Libro y Mapa.
        /// </summary>
        /// <returns></returns>
        public override abstract string ToString();
        
        /// <summary>
        /// Metodo para avanzar los estados de los documentos (Libro / Mapa)
        /// </summary>
        /// <returns></returns>
        public bool AvanzarEstado()
        {
            if (this.estado == Paso.Inicio)
            {
                this.estado = Paso.Distruibuido;
            }
            else if (this.estado == Paso.Distruibuido)
            {
                this.estado = Paso.EnEscaner;
            }
            else if (this.estado == Paso.EnEscaner)
            {
                this.estado = Paso.EnRevision;
            }
            else if (this.estado == Paso.EnRevision)
            {
                this.estado = Paso.Terminado;
            }
            return true;
        }

        //Un enumerado del estado de los documentos.
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
