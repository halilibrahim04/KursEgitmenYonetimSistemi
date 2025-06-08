using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAndInstructorManagementSystem
{
    public abstract class Egitmen
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

}
