using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Hastane.App
{

    public enum MuayeneTuru
    {
        Normal,Konsultasyon,Kontrol
    }
    public class Muayene
    {
        public int Id { get; set; }

        public DateTime MuayeneTarihi { get; set; }

        public MuayeneTuru Tur { get; set; }

        public Doktor Doktor { get; set; }

        public Hasta Hasta { get; set; }

        public string Teshis { get; set; }

        public Tetkik[] Tetkikler { get; set; }

        public Recete Recete { get; set; }
    }
}
