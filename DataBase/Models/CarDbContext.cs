using Microsoft.EntityFrameworkCore;

namespace DataBase.Models
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasData(
              
                new Car { Id = 1, FirstName = "Arif Hakan", LastName = "Başşa", TcNo = 53129486750, Sifre = 192736 },
                new Car { Id = 2, FirstName = "Alşan", LastName = "Kostik", TcNo = 68213054791, Sifre = 485920 },
                new Car { Id = 3, FirstName = "Ebrar", LastName = "Arslan", TcNo = 75981324605, Sifre = 374819 },
                new Car { Id = 4, FirstName = "Kerim", LastName = "Çıvak", TcNo = 61054829374, Sifre = 528361 },
                new Car { Id = 5, FirstName = "Yiğit", LastName = "Turan", TcNo = 47562031859, Sifre = 697045 },
                new Car { Id = 6, FirstName = "Taner Talip", LastName = "Yılmaz", TcNo = 92374518620, Sifre = 820497 },
                new Car { Id = 7, FirstName = "Rana", LastName = "Çalbay", TcNo = 83710249536, Sifre = 103584 },
                new Car { Id = 8, FirstName = "Alperen", LastName = "Karayol", TcNo = 19485632075, Sifre = 614289 },
                new Car { Id = 9, FirstName = "Mehmetcan", LastName = "Eker", TcNo = 56298317420, Sifre = 750213 },
                new Car { Id = 10, FirstName = "Cihat Eren", LastName = "Kiraz", TcNo = 48120759638, Sifre = 341890 },
                new Car { Id = 11, FirstName = "Rabia", LastName = "Erdoğan", TcNo = 72954018365, Sifre = 905432 },
                new Car { Id = 12, FirstName = "Emir", LastName = "Orhan", TcNo = 31682574098, Sifre = 283746 },
                new Car { Id = 13, FirstName = "Cemre", LastName = "Akkaya", TcNo = 65047298130, Sifre = 697152 },
                new Car { Id = 14, FirstName = "Alpcan", LastName = "Ünlü", TcNo = 23758104962, Sifre = 874920 },
                new Car { Id = 15, FirstName = "Kerem", LastName = "Eskiköy", TcNo = 90321658470, Sifre = 530189 },
                new Car { Id = 16, FirstName = "Kaan", LastName = "Yüceyurt", TcNo = 54278163904, Sifre = 412385 },
                new Car { Id = 17, FirstName = "Kaan Emir", LastName = "Dağ", TcNo = 80746521390, Sifre = 690274 },
                new Car { Id = 18, FirstName = "Yağız Can", LastName = "Yanar", TcNo = 16893057482, Sifre = 587031 },
                new Car { Id = 19, FirstName = "Ege", LastName = "Aydın", TcNo = 73429568102, Sifre = 739520 },
                new Car { Id = 20, FirstName = "Rüzğar", LastName = "Şahin", TcNo = 29038517467, Sifre = 426893 },
                new Car { Id = 21, FirstName = "Ebru", LastName = "Öz", TcNo = 51927640384, Sifre = 518703 },
                new Car { Id = 22, FirstName = "Tansu", LastName = "Ustabaş", TcNo = 86374210597, Sifre = 964215 },
                new Car { Id = 23, FirstName = "Serhat", LastName = "Taşhan", TcNo = 47509128360, Sifre = 703194 },
                new Car { Id = 24, FirstName = "Mahmut can", LastName = "Fettahoğlu", TcNo = 62183940517, Sifre = 827564 },
                new Car { Id = 25, FirstName = "Efe Kadir", LastName = "Burhan", TcNo = 75036821940, Sifre = 632485 },
                new Car { Id = 26, FirstName = "Faruk Ömer", LastName = "Ateş", TcNo = 83051794268, Sifre = 581927 },
                new Car { Id = 27, FirstName = "Efekan", LastName = "Yılmaz", TcNo = 94217503861, Sifre = 748302 }
                
                );


        }
    }
}
