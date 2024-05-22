using Entidades;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            // LIBROS
            // Caminos felices
            Libro l1 = new Libro("Yerma", "García Lorca, Federico", 1995, "11111", "22222", 100);
            Libro l2 = new Libro("Bodas de sangre", "García Lorca, Federico", 1997, "11112", "22223", 200);
            // Barcode repetido
            Libro l3 = new Libro("Codebar repetido", "García Lorca, Federico", 2003, "11113", "22222", 3);
            // ISBN repetido
            Libro l4 = new Libro("ISBN repetido", "García Lorca, Federico", 2003, "11112", "22224", 2);
            // Título-autor repetido
            Libro l5 = new Libro("Yerma", "García Lorca, Federico", 2003, "55555", "66666", 1);

            //MAPAS 
            // Caminos felices
            Mapa m1 = new Mapa("Buenos Aires", "Instituto Geográfico de Buenos Aires", 2005, "", "99999", 30, 15); //450
            Mapa m2 = new Mapa("Mendoza", "Instituto Geográfico de Mendoza", 2008, "", "99990", 100, 30); //300
            Mapa m3 = new Mapa("Santa Fe", "Instituto Geográfico de Santa Fe", 2010, "", "99991", 80, 30); //2400
            Mapa m4 = new Mapa("Corrientes", "Instituto Geográfico de Corrientes", 2013, "", "99992", 50, 25); //1250
            // Barcode repetido
            Mapa m5 = new Mapa("Barcode repetido", "Instituto Geográfico", 2015, "", "99999", 40, 15);//600
            // Título - autor - superficie
            Mapa m6 = new Mapa("Buenos Aires", "Instituto Geográfico de Buenos Aires", 2005, "", "99993", 30, 15);//200

            //ESCANERS
            Escaner l = new Escaner("HP", Escaner.TipoDoc.libro);
            Escaner m = new Escaner("HP", Escaner.TipoDoc.mapa);

            bool pudo = l + l1;
            pudo = l + l2;
            pudo = l + l3;
            pudo = l + l4;
            pudo = l + l5;
            pudo = m + m1;
            pudo = m + m2;
            pudo = m + m3;
            pudo = m + m4;
            pudo = m + m5;
            pudo = m + m6;
            pudo = m + l1;
            pudo = l + m1;

            l1.AvanzarEstado();
            l1.AvanzarEstado();
            l2.AvanzarEstado();
            l2.AvanzarEstado();
            m2.AvanzarEstado();
            m3.AvanzarEstado();
            m3.AvanzarEstado();
            m3.AvanzarEstado();
            m4.AvanzarEstado();
            m4.AvanzarEstado();
            m4.AvanzarEstado();
            m4.AvanzarEstado();
            m4.AvanzarEstado();

            Informes.MostrarDistribuidos(l, out int extensionLibroDistr, out int cantidadLibroDistr, out string resumenLibroDistr);
            Informes.MostrarEnEscaner(l, out int extensionLibroEnEsc, out int cantidadLibroEnEsc, out string resumenLibroEnEsc);
            Informes.MostrarEnRevision(l, out int extensionLibroEnRev, out int cantidadLibroEnRev, out string resumenLibroEnRev);
            Informes.MostrarTerminados(l, out int extensionLibroTerminado, out int cantidadLibroTerminado, out string resumenLibroTerminado);

            Informes.MostrarDistribuidos(m, out int extensionMapaDistr, out int cantidadMapaDistr, out string resumenMapaDistr);
            Informes.MostrarEnEscaner(m, out int extensionMapaEnEsc, out int cantidadMapaEnEsc, out string resumenMapaEnEsc); ;
            Informes.MostrarEnRevision(m, out int extensionMapaEnRev, out int cantidadMapaEnRev, out string resumenMapaEnRev);
            Informes.MostrarTerminados(m, out int extensionMapaTerminado, out int cantidadMapaTerminado, out string resumenMapaTerminado);

            int puntos = 0;

            if (extensionLibroDistr == 0) { puntos += 3; }
            if (cantidadLibroDistr == 0) { puntos += 1; }
            if (resumenLibroDistr == "") { puntos += 1; }

            if (extensionLibroEnEsc == 0) { puntos += 3; }
            if (cantidadLibroEnEsc == 0) { puntos += 1; }
            if (resumenLibroEnEsc == "") { puntos += 1; }

            if (extensionLibroEnRev == l1.NumPaginas + l2.NumPaginas) { puntos += 3; }
            if (cantidadLibroEnRev == 2) { puntos += 1; }
            if (resumenLibroEnRev == l1.ToString() + l2.ToString()) { puntos += 1; }

            if (extensionLibroTerminado == 0) { puntos += 3; }
            if (cantidadLibroTerminado == 0) { puntos += 1; }
            if (resumenLibroTerminado == "") { puntos += 1; }

            if (extensionMapaDistr == m1.Superficie) { puntos += 3; }
            if (cantidadMapaDistr == 1) { puntos += 1; }
            if (resumenMapaDistr == m1.ToString()) { puntos += 1; }

            if (extensionMapaEnEsc == m2.Superficie) { puntos += 3; }
            if (cantidadMapaEnEsc == 1) { puntos += 1; }
            if (resumenMapaEnEsc == m2.ToString()) { puntos += 1; }

            if (extensionMapaEnRev == 0) { puntos += 3; }
            if (cantidadMapaEnRev == 0) { puntos += 1; }
            if (resumenMapaEnRev == "") { puntos += 1; }

            if (extensionMapaTerminado == m3.Superficie + m4.Superficie) { puntos += 3; }
            if (cantidadMapaTerminado == 2) { puntos += 1; }
            if (resumenMapaTerminado == m3.ToString() + m4.ToString()) { puntos += 1; }

            Console.WriteLine($"Puntos: {puntos} / 40");

            Console.WriteLine("LIBROS DISTRIBUIDOS");
            Console.WriteLine($"Cantidad de libros ya distribuidos: {cantidadLibroDistr}.");
            Console.WriteLine($"Cantidad de páginas ya distribuidas: {extensionLibroDistr}.");
            Console.WriteLine(resumenLibroDistr);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS EN ESCANER");
            Console.WriteLine($"Cantidad de libros en el escáner: {cantidadLibroEnEsc}.");
            Console.WriteLine($"Cantidad de páginas en el escáner: {extensionLibroEnEsc}.");
            Console.WriteLine(resumenLibroEnEsc);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS EN REVISIÓN");
            Console.WriteLine($"Cantidad de libros en el escáner: {cantidadLibroEnRev}.");
            Console.WriteLine($"Cantidad de páginas en el escáner: {extensionLibroEnRev}.");
            Console.WriteLine(resumenLibroEnRev);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS TERMINADOS");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadLibroTerminado}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionLibroTerminado}.");
            Console.WriteLine(resumenLibroTerminado);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS DISTRIBUIDOS");
            Console.WriteLine($"Cantidad de mapas ya distribuidos: {cantidadMapaDistr}.");
            Console.WriteLine($"Cantidad de cm2 ya distribuidos: {extensionMapaDistr}.");
            Console.WriteLine(resumenMapaDistr);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS EN ESCANER");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaEnEsc}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaEnEsc}.");
            Console.WriteLine(resumenMapaEnEsc);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS EN REVISIÓN");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaEnRev}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaEnRev}.");
            Console.WriteLine(resumenMapaEnRev);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS TERMINADOS");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaTerminado}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaTerminado}.");
            Console.WriteLine(resumenMapaTerminado);
            Console.WriteLine("---------------------");

            Console.ReadKey();


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
