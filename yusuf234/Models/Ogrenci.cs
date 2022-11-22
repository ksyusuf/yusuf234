namespace yusuf234.Models
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }

        public String AdSoyad { get; set; }

        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }

        public int HobiId { get; set; }
        public Hobi Hobi { get; set; }

        public int HocaId { get; set; }
        public Hoca Hoca { get; set; }

        public int RHocaId { get; set; }
        // rehber hoca id
    }
}
