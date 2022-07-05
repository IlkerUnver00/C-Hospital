using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Hastane.App
{
    public enum Cinsiyet
    {
        Kadin,Erkek
    }

    public enum KanGrubu{
        SifirPozitif,SifirNegatif,APozitif,ANegatif,BPozitif,BNegatif,ABPozitif,ABNegatif
    }
    public class Hasta
    {
        public int Id { get; set; }

        public string TcKimlikNo { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

        public KanGrubu KanGrubu { get; set; }

        public string Telefon { get; set; }
    }
}
