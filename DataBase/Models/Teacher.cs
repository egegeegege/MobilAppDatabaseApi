namespace DataBase.Models
{
    public class Teacher : BaseEntitiy //BaseEntity sınıfından miras alır
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public string TelefonNo { get; set; }
        public string OturduguIlce { get; set; }
        public string UzmanlıkAlanıDersler { get; set; }
        public string Cinsiyet { get; set; }
    }
}
