using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Escaner;

namespace Entidades
{
    public static class Informes
    {
        public static void MostrarDistribuidos(Escaner e,out int extension,out int cantidad,out string resumen) 
        {
            MostrarDocumentosPorEstado(e,Documento.Paso.Distruibuido,out extension,out cantidad,out resumen);
        }

        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }

        /// <summary>
        /// Se utiliza para mostrar la suma total de hojas y la cantidad de Libros y en caso de los Mapas
        /// es utilizado para la cantidad total de superficie entre todos los Mapas y la cantidad que se utilizo para dicha suma
        /// y este metodo al ser statico solo puede ser accedido dentro de su misma clase y reutilizado en los demas metodos vistos anteriormente.
        /// </summary>
        /// <param name="e">Se utiliza para acceder a la lista de Mapas o Libros</param>
        /// <param name="estado">Se proporciona el estado en el cual esta el documento puede ser Distribuido,EnEscaner,EnRevision o Terminado</param>
        /// <param name="extension">El total de hojas en caso de Libros o el total de superficien en caso de Mapas</param>
        /// <param name="cantidad">Cantidad total de documentos utilizados para la suma que se calcula en extension</param>
        /// <param name="resumen">Información brindada en formato string</param>
        private static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {
            extension = 0;
            cantidad = 0;
            resumen = "";
            foreach (Documento item in e.ListaDocumentos)
            {
                if (item.Estado == estado)
                {
                    if (item.GetType() == typeof(Mapa))
                    {
                        Mapa mapa = (Mapa)item;
                        extension = extension + mapa.Superficie;
                        cantidad++;
                        resumen += mapa.ToString();

                    }
                    else
                    {
                        Libro libro = (Libro)item;
                        extension = extension + libro.NumPaginas;
                        cantidad++;
                        resumen += libro.ToString();
                    }

                }
            }
        }

    }

}
