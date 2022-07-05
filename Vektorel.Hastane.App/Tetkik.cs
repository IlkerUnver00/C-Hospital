using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Hastane.App
{

    public enum TetkikTuru
    {
        Kan,Rontgen,MR,Idrar,EKG
    }
    public class Tetkik
    {
        public int Id { get; set; }

        public TetkikTuru Tur { get; set; }

        public DateTime Tarihi { get; set; }

        public Doktor Onaylayan { get; set; }
    }
}
