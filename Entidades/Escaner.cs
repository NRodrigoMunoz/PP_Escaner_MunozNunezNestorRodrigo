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

        public bool CambiarEstadoDocumento(Documento d)
        {
            if (listaDocumentos.Contains(d))
            {
                d.AvanzarEstado();
                return true;
            }
            return false;
        }

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
