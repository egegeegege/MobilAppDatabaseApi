namespace DataBase.Models
{
    public class Student : BaseEntitiy
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TcNo { get; set; }
        public int Sifre { get; set; }
        public int OkulNo { get; set; }
        public string Sınıf { get; set; }
    }
}
