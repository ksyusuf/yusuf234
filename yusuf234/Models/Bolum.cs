namespace yusuf234.Models
{
    public class Bolum
        // publica ve internal olması durumu değiştiriyor
    {
        public int BolumId { get; set; }
        public string Adi { get; set; }
        public ICollection<Ogrenci> Ogrenci { get; set; }
    }
}