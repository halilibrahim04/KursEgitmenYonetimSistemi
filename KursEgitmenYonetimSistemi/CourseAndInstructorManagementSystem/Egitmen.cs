using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAndInstructorManagementSystem
{
/*    public abstract class Egitmen
    {
        public int EgitmenID { get; set; }
        public string AdSoyad { get; set; }
        public virtual string UzmanlikAlani { get; set; }

        public virtual string EgitmenBilgisi()
        {
            return $"Eğitmen: {AdSoyad}, Uzmanlık: {UzmanlikAlani}";
        }
    }

    public class DilEgitmeni : Egitmen
    {
        public string BildigiDiller { get; set; }

        public override string UzmanlikAlani => "Dil";

        public override string EgitmenBilgisi()
        {
            base.EgitmenBilgisi();
            return $"Bildiği Diller: {BildigiDiller}";
        }
    }

    public class ProgramlamaEgitmeni : Egitmen
    {
        public string BildigiDiller { get; set; }

        public override string UzmanlikAlani => "Programlama";

        public override string EgitmenBilgisi()
        {
            base.EgitmenBilgisi();
            return $"Programlama Dilleri: {BildigiDiller}";
        }
    }
    public class ResimEgitmeni : Egitmen
    {
        public string KullandigiMalzemeler { get; set; }

        public override string EgitmenBilgisi()
        {
            base.EgitmenBilgisi();
            return $"Kullandığı Malzemeler: {KullandigiMalzemeler}";
        }
    }

    public class MuzikEgitmeni : Egitmen
    {
        public string CalabildigiEnstrumanlar { get; set; }

        public override string EgitmenBilgisi()
        {
            base.EgitmenBilgisi();
            return $"Çalabildiği Enstrümanlar: {CalabildigiEnstrumanlar}";
        }
    }
*/
        public abstract class Egitmen
    {
        private int egitmenID;
        private string adSoyad;
        private string uzmanlikAlani;

        public int EgitmenID
        {
            get => egitmenID;
            set => egitmenID = value > 0 ? value : throw new ArgumentException("Eğitmen ID pozitif olmalı.");
        }

        public string AdSoyad
        {
            get => adSoyad;
            set => adSoyad = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Ad soyad boş olamaz.") : value;
        }

        public virtual string UzmanlikAlani
        {
            get => uzmanlikAlani;
            set => uzmanlikAlani = value ?? string.Empty;
        }

        protected Egitmen()
        {
        }
        protected Egitmen(int egitmenID, string adSoyad, string uzmanlikAlani)
        {
            EgitmenID = egitmenID;
            AdSoyad = adSoyad;
            UzmanlikAlani = uzmanlikAlani;
        }

        public virtual string EgitmenBilgisi()
        {
            return $"Eğitmen: {AdSoyad}, Uzmanlık: {UzmanlikAlani}";
        }
    }

    public class DilEgitmeni : Egitmen
    {
        private string bildigiDiller;

        public string BildigiDiller
        {
            get => bildigiDiller;
            set => bildigiDiller = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Bildiği diller boş olamaz.") : value;
        }

        public override string UzmanlikAlani => "Dil";

        public DilEgitmeni()
        {
        }
        public DilEgitmeni(int egitmenID, string adSoyad, string bildigiDiller)
            : base(egitmenID, adSoyad, "Dil")
        {
            BildigiDiller = bildigiDiller;
        }

        public override string EgitmenBilgisi()
        {
            return $"{base.EgitmenBilgisi()}, Bildiği Diller: {BildigiDiller}";
        }
    }

    public class ProgramlamaEgitmeni : Egitmen
    {
        private string bildigiDiller;

        public string BildigiDiller
        {
            get => bildigiDiller;
            set => bildigiDiller = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Bildiği diller boş olamaz.") : value;
        }

        public override string UzmanlikAlani => "Programlama";
        public ProgramlamaEgitmeni()
        {
        }
        public ProgramlamaEgitmeni(int egitmenID, string adSoyad, string bildigiDiller)
            : base(egitmenID, adSoyad, "Programlama")
        {
            BildigiDiller = bildigiDiller;
        }

        public override string EgitmenBilgisi()
        {
            return $"{base.EgitmenBilgisi()}, Programlama Dilleri: {BildigiDiller}";
        }
    }

    public class ResimEgitmeni : Egitmen
    {
        private string kullandigiMalzemeler;

        public string KullandigiMalzemeler
        {
            get => kullandigiMalzemeler;
            set => kullandigiMalzemeler = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Kullanılan malzemeler boş olamaz.") : value;
        }

        public override string UzmanlikAlani => "Resim";

        public ResimEgitmeni()
        {
        }
        public ResimEgitmeni(int egitmenID, string adSoyad, string kullandigiMalzemeler)
            : base(egitmenID, adSoyad, "Resim")
        {
            KullandigiMalzemeler = kullandigiMalzemeler;
        }

        public override string EgitmenBilgisi()
        {
            return $"{base.EgitmenBilgisi()}, Kullandığı Malzemeler: {KullandigiMalzemeler}";
        }
    }

    public class MuzikEgitmeni : Egitmen
    {
        private string calabildigiEnstrumanlar;

        public string CalabildigiEnstrumanlar
        {
            get => calabildigiEnstrumanlar;
            set => calabildigiEnstrumanlar = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Çalabildiği enstrümanlar boş olamaz.") : value;
        }

        public override string UzmanlikAlani => "Müzik";

        public MuzikEgitmeni()
        {
        }
        public MuzikEgitmeni(int egitmenID, string adSoyad, string calabildigiEnstrumanlar)
            : base(egitmenID, adSoyad, "Müzik")
        {
            CalabildigiEnstrumanlar = calabildigiEnstrumanlar;
        }

        public override string EgitmenBilgisi()
        {
            return $"{base.EgitmenBilgisi()}, Çalabildiği Enstrümanlar: {CalabildigiEnstrumanlar}";
        }
    }
}
