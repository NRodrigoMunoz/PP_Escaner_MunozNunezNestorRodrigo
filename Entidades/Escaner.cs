using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        //Atributos
        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;
        
        //Propiedades
        public List<Documento> ListaDocumentos { get => listaDocumentos;}
        public Departamento Locacion { get => locacion;}
        public string Marca { get => marca;}
        public TipoDoc Tipo { get => tipo;}

        /// <summary>
        /// Constructor en el que se instancia la lista y segun el tipo de Documento sea Libro o Mapa se le asigna una locación
        /// procesosTecnicos en caso de libros, mapoteca en caso de mapas y nulo si no se pasa su tipo de documento.
        /// </summary>
        /// <param name="marca">La marca del escaner ejemplo Samsung,HP,Epson,etc</param>
        /// <param name="tipo">Tipo de documento mapa o libro.</param>
        public Escaner(string marca,TipoDoc tipo)
        {
            listaDocumentos = new List<Documento>();
            this.marca = marca;
            this.tipo = tipo;
            if (tipo == TipoDoc.libro)
            {
                this.locacion = Departamento.procesosTecnicos;
            }
            else if(tipo == TipoDoc.mapa)
            {
                this.locacion = Departamento.mapoteca;
            }
            else
            {
                this.locacion = Departamento.nulo;
            }
        }

        
        /// <summary>
        /// Agrega el documento a la lista según su localización y su tipo ademas los avanza de estado.
        /// </summary>
        /// <param name="e">Se utiliza para poder acceder a la lista para agregar el documento.</param>
        /// <param name="d">Se le pasa por parametro un tipo de documento puede ser Mapa o Libro.</param>
        /// <returns></returns>
        public static bool operator +(Escaner e,Documento d)
        {
            if (e != d && d.Estado == Documento.Paso.Inicio)
            {
                if (e.Locacion == Departamento.procesosTecnicos && d.GetType() == typeof(Libro))
                {
                    d.AvanzarEstado();
                    e.ListaDocumentos.Add(d);
                    return true;

                }
                else if (e.locacion == Departamento.mapoteca && d.GetType() == typeof(Mapa))
                {
                    d.AvanzarEstado();
                    e.ListaDocumentos.Add(d);
                    return true;
                }
                
            }
            return false;
        }
        
        /// <summary>
        /// Compara si los documentos son iguales dentro de una lista.
        /// </summary>
        /// <param name="e">Se utiliza para acceder a la lista y poder comparar los documentos.</param>
        /// <param name="d">Es el documento a comparar con los demas que esten en la lista.</param>
        /// <returns></returns>
        public static bool operator ==(Escaner e,Documento d)
        {
            
            TipoDoc tipoDeDocumento = d is Libro ? TipoDoc.libro : TipoDoc.mapa;
            if (e.tipo == tipoDeDocumento)
            {
                if (e.ListaDocumentos.Count() == 0)
                {
                    return false;
                }
                else
                {
                    foreach (Documento item in e.ListaDocumentos)
                    {
                        if ((d is Mapa && (Mapa)d == (Mapa)item) ||
                        (d is Libro && (Libro)d == (Libro)item))
                        {

                            return true;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }


        public static bool operator !=(Escaner e,Documento d)
        {
            return !(e == d);
        }

        /// <summary>
        /// Busca dentro de la lista el documento brindado por parametro y avanza su estado.
        /// </summary>
        /// <param name="d">Es el documento al cual se le quiere avanzar su estado.</param>
        /// <returns></returns>
        public bool CambiarEstadoDocumento(Documento d)
        {
            if (listaDocumentos.Contains(d))
            {
                d.AvanzarEstado();
                return true;
            }
            return false;
        }

        //La locacion que se le asigna en el constructor dependiendo de su tipo.
        public enum Departamento
        {
            nulo,
            mapoteca,
            procesosTecnicos
        }

        //Los tipos de lectura del escaner.
        public enum TipoDoc
        {
            libro,
            mapa
        }

    }
}
