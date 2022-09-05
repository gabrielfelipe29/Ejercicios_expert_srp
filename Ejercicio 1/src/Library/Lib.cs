using System;

namespace SRP
{
    public class Lib
    {
            /*
            Lib almacena datos sobre la libreria, si es necesario cambiar datos sobre la libreria ahora 
            es solo necesario modificar la clase lib. 
            */
        public string LibrarySector { get; set; }
        public string LibraryShelve { get; set; }
        public Lib(string Sector, string Shelve)
        {

            this.LibrarySector = Sector;
            this.LibraryShelve = Shelve;


        }


    }


}