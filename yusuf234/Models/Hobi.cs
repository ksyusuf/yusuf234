namespace yusuf234.Models
{
    public class Hobi
    {
        public int HobiId { get; set; }
        public string Adi { get; set; }
        public ICollection<Ogrenci> Ogrenci { get; set; }
    }
}