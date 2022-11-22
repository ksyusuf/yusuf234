namespace yusuf234.Models
{
    public class Hoca
    {
        public int HocaId { get; set; }
        public string Adi { get; set; }
        public ICollection<Ogrenci> Ogrenci { get; set; }
    }
}