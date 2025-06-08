using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAndInstructorManagementSystem
{
    public abstract class Kurs
    {
        public int KursID { get; set; }
        public string KursAdi { get; set; }
        public virtual string KursTuru { get; set; }
        public Egitmen Egitmen { get; set; }

        public virtual string KursBilgisi()
        {
            return ($"Kurs: {KursAdi}, Tür: {KursTuru}, Eğitmen: {Egitmen?.AdSoyad}");
        }

    }
    public class DilKursu : Kurs
    {
        public string Dil { get; set; }
        public string Seviye { get; set; }

        public override string KursTuru => "Dil";

        public override string KursBilgisi()
        {
            base.KursBilgisi();
            return ($"Dil: {Dil}, Seviye: {Seviye}");
        }
    }

    public class ProgramlamaKursu : Kurs
    {
        public string ProgramlamaDili { get; set; }
        public string Zorluk { get; set; }

        public override string KursTuru => "Programlama";

        public override string KursBilgisi()
        {
            base.KursBilgisi();
            return ($"Programlama Dili: {ProgramlamaDili}, Zorluk: {Zorluk}");
        }
    }

    public class ResimKursu : Kurs
    {
        public string Teknik { get; set; }

        public override string KursBilgisi()
        {
            base.KursBilgisi();
            return ($"Öğretilecek Teknik: {Teknik}");
        }
    }

    public class MuzikKursu : Kurs
    {
        public string Enstruman { get; set; }

        public override string KursBilgisi()
        {
            base.KursBilgisi();
            return ($"Kullanılacak Enstrüman: {Enstruman}");
        }
    }

}
