using Entidades;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Pruebas ctrl +k +u descomento ctrl +k +c comento

            //Instanciacion de los Libros
            //Libro libro = new Libro("Yerma", "García Lorca, Federico", 1995, "1114", "22222", 1000);
            //Libro libro1 = new Libro("A", "Z", 1995, "1114", "11111", 800);
            //Libro libro2 = new Libro("B", "S, Federico", 2004, "1154", "22222", 300);
            //Libro libro3 = new Libro("C", "Q", 1995, "10000", "545", 890);
            //Libro libro4 = new Libro("Yerma", "García Lorca, Federico", 122, "2858", "244442", 250);

            //Instanciacion de los Mapas
            //Mapa mapa = new Mapa("Ciudad Autonoma de buenos aires", "Instituto de Geografia", 2022, "", "8888", 20, 30);
            //Mapa mapa2 = new Mapa("A1", "pedrito", 1885, "", "1732", 10, 20);
            //Mapa mapa3 = new Mapa("Ciudad Autonoma de buenos aires", "Instituto de Geografia", 2022, "", "7777", 20, 30);
            //Mapa mapa4 = new Mapa("A2", "jorjito", 1765, "1774", "8888", 17, 20);
            //Mapa mapa5 = new Mapa("A3", "pepe", 1984, "", "2222", 15, 10);

            //Instanciocin de escaner
            //Escaner escaner = new Escaner("a1", Escaner.TipoDoc.libro);
            //Escaner escaner2 = new Escaner("a2", Escaner.TipoDoc.mapa);

            //Agrego los libros
            //string strdocumento0 = escaner + libro ? libro.ToString() : "Error" + libro.ToString();
            //string strdocumento1 = escaner + libro1 ? libro1.ToString() : "Error" + libro1.ToString();
            //string strdocumento2 = escaner + libro2 ? libro.ToString() : "Error" + libro2.ToString();
            //string strdocumento3 = escaner + libro3 ? libro3.ToString() : "Error" + libro3.ToString();
            //string strdocumento4 = escaner + libro4 ? libro4.ToString() : "Error" + libro4.ToString();

            //Agrego los mapas
            //string strdocumento5 = escaner2 + mapa ? mapa.ToString() : "Error" + mapa.ToString();
            //string strdocumento6 = escaner2 + mapa2 ? mapa2.ToString() : "Error" + mapa2.ToString();
            //string strdocumento7 = escaner2 + mapa3 ? mapa3.ToString() : "Error" + mapa3.ToString();
            //string strdocumento8 = escaner2 + mapa4 ? mapa4.ToString() : "Error" + mapa4.ToString();
            //string strdocumento9 = escaner2 + mapa5 ? mapa5.ToString() : "Error" + mapa5.ToString();

            //Control de la lista no repetidos y que alla mapas dentro de escaner libros y viceversa.
            //foreach (Documento item in escaner.ListaDocumentos)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Revision de Informes avance de estado 
            //int informe;
            //int cantidad;
            //string resumen;
            //escaner.CambiarEstadoDocumento(libro3);
            //escaner.CambiarEstadoDocumento(libro3);
            //Informes.MostrarDistribuidos(escaner,out informe,out cantidad,out resumen);
            //Informes.MostrarEnEscaner(escaner, out informe, out cantidad, out resumen);
            //Informes.MostrarEnRevisión(escaner, out informe, out cantidad, out resumen);
            //Informes.MostrarTerminados(escaner, out informe, out cantidad, out resumen);
            //Console.WriteLine($"{cantidad} {informe} {resumen}");


            //Funcionalidad de las sobrecargas
            //if (libro != libro1)
            //{
            //    Console.WriteLine(libro1.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Tiene el mismo ISbn\n");
            //}
            //if (libro != libro2)
            //{
            //    Console.WriteLine(libro2.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Tiene el mismo Barcode\n");
            //}
            //if (libro != libro3)
            //{
            //    Console.WriteLine(libro3.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Tendria que mostrar el libro\n");
            //}
            //if (libro != libro4)
            //{
            //    Console.WriteLine(libro4.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Mismo autor y titulo\n");
            //}


            //if (mapa != mapa2)
            //{
            //    Console.WriteLine(mapa2.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Tiene que mostrarse\n");
            //}
            //if (mapa != mapa3)
            //{
            //    Console.WriteLine(mapa3.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Todo igual menos el barcode\n");
            //}
            //if (mapa != mapa4)
            //{
            //    Console.WriteLine(mapa4.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Lo unico igual es el barcode\n");
            //}
            //if (mapa != mapa5)
            //{
            //    Console.WriteLine(mapa5.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Tiene que mostrarse\n");
            //}
        }
    }
}
