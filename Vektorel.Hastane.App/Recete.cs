using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Hastane.App
{
    public class Recete
    {
        public int Id { get; set; }

        public string ReceteNumarasi { get; set; }

        public Ilac[] Ilaclar { get; set; }
    }
}
