using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Hastane.App
{
    public enum Brans
    {
        Onkolog,Psikiyatrist,Disci,Gozcu,KBB,Ortopedist,Kardiyolog,GenelCerrah
    }

    public class Doktor
    {
        public int Id { get; set; }

        public string TcKimlikNo { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Telefon { get; set; }

        public string Unvan { get; set; }

        public Brans Brans { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

    }
}
