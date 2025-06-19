using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAndInstructorManagementSystem
{
/*    public abstract class Kurs
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
*/
        public abstract class Kurs
    {
        private int kursID;
        private string kursAdi;
        private string kursTuru;
        private Egitmen egitmen;

        public int KursID
        {
            get => kursID;
            set => kursID = value > 0 ? value : throw new ArgumentException("Kurs ID pozitif olmalı.");
        }

        public string KursAdi
        {
            get => kursAdi;
            set => kursAdi = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Kurs adı boş olamaz.") : value;
        }

        public virtual string KursTuru
        {
            get => kursTuru;
            set => kursTuru = value ?? string.Empty;
        }

        public Egitmen Egitmen
        {
            get => egitmen;
            set => egitmen = value; // Null olabilir
        }

        public virtual string KursBilgisi()
        {
            return $"Kurs: {KursAdi}, Tür: {KursTuru}, Eğitmen: {Egitmen?.AdSoyad ?? "Belirtilmemiş"}";
        }
    }

    public class DilKursu : Kurs
    {
        private string dil;
        private string seviye;

        public string Dil
        {
            get => dil;
            set => dil = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Dil boş olamaz.") : value;
        }

        public string Seviye
        {
            get => seviye;
            set => seviye = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Seviye boş olamaz.") : value;
        }

        public override string KursTuru => "Dil";

        public override string KursBilgisi()
        {
            return $"{base.KursBilgisi()}, Dil: {Dil}, Seviye: {Seviye}";
        }
    }

    public class ProgramlamaKursu : Kurs
    {
        private string programlamaDili;
        private string zorluk;

        public string ProgramlamaDili
        {
            get => programlamaDili;
            set => programlamaDili = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Programlama dili boş olamaz.") : value;
        }

        public string Zorluk
        {
            get => zorluk;
            set => zorluk = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Zorluk seviyesi boş olamaz.") : value;
        }

        public override string KursTuru => "Programlama";

        public override string KursBilgisi()
        {
            return $"{base.KursBilgisi()}, Programlama Dili: {ProgramlamaDili}, Zorluk: {Zorluk}";
        }
    }

    public class ResimKursu : Kurs
    {
        private string teknik;

        public string Teknik
        {
            get => teknik;
            set => teknik = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Teknik boş olamaz.") : value;
        }

        public override string KursTuru => "Resim";

        public override string KursBilgisi()
        {
            return $"{base.KursBilgisi()}, Öğretilecek Teknik: {Teknik}";
        }
    }

    public class MuzikKursu : Kurs
    {
        private string enstruman;

        public string Enstruman
        {
            get => enstruman;
            set => enstruman = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Enstrüman boş olamaz.") : value;
        }

        public override string KursTuru => "Müzik";

        public override string KursBilgisi()
        {
            return $"{base.KursBilgisi()}, Kullanılacak Enstrüman: {Enstruman}";
        }
    }
}
