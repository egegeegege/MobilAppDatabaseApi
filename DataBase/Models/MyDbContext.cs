using Microsoft.EntityFrameworkCore;

namespace DataBase.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(

                new Student { Id = 1, Ad = "Arif Hakan", Soyad = "Başşa", TcNo = 53129486750, Sifre = 192736, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 2, Ad = "Alişan", Soyad = "Kostik", TcNo = 68213054791, Sifre = 485920, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 3, Ad = "Ebrar", Soyad = "Arslan", TcNo = 75981324605, Sifre = 374819, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 4, Ad = "Kerim", Soyad = "Çıvak", TcNo = 61054829374, Sifre = 528361, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 5, Ad = "Yiğit", Soyad = "Turan", TcNo = 47562031859, Sifre = 697045, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 6, Ad = "Taner Talip", Soyad = "Yılmaz", TcNo = 92374518620, Sifre = 820497, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 7, Ad = "Rana", Soyad = "Çalbay", TcNo = 83710249536, Sifre = 103584, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 8, Ad = "Alperen", Soyad = "Karayol", TcNo = 19485632075, Sifre = 614289, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 9, Ad = "Mehmetcan", Soyad = "Eker", TcNo = 56298317420, Sifre = 750213, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 10, Ad = "Cihat Eren", Soyad = "Kiraz", TcNo = 48120759638, Sifre = 341890, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 11, Ad = "Rabia", Soyad = "Erdoğan", TcNo = 72954018365, Sifre = 905432, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 12, Ad = "Emir", Soyad = "Orhan", TcNo = 31682574098, Sifre = 283746, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 13, Ad = "Cemre", Soyad = "Akkaya", TcNo = 65047298130, Sifre = 697152, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 14, Ad = "Alpcan", Soyad = "Ünlü", TcNo = 23758104962, Sifre = 874920, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 15, Ad = "Kerem", Soyad = "Eskiköy", TcNo = 90321658470, Sifre = 530189, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 16, Ad = "Kaan", Soyad = "Yüceyurt", TcNo = 54278163904, Sifre = 412385, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 17, Ad = "Kaan Emir", Soyad = "Dağ", TcNo = 80746521390, Sifre = 690274, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 18, Ad = "Yağız Can", Soyad = "Yanar", TcNo = 16893057482, Sifre = 587031, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 19, Ad = "Ege", Soyad = "Aydın", TcNo = 73429568102, Sifre = 739520, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 20, Ad = "Rüzğar", Soyad = "Şahin", TcNo = 29038517467, Sifre = 426893, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 21, Ad = "Ebru", Soyad = "Öz", TcNo = 51927640384, Sifre = 518703, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 22, Ad = "Tansu", Soyad = "Ustabaş", TcNo = 86374210597, Sifre = 964215, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 23, Ad = "Serhat", Soyad = "Taşhan", TcNo = 47509128360, Sifre = 703194, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 24, Ad = "Mahmut can", Soyad = "Fettahoğlu", TcNo = 62183940517, Sifre = 827564, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 25, Ad = "Efe Kadir", Soyad = "Burhan", TcNo = 75036821940, Sifre = 632485, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 26, Ad = "Faruk Ömer", Soyad = "Ateş", TcNo = 83051794268, Sifre = 581927, Sınıf = "11-B", Aktif = "Evet" },
                new Student { Id = 27, Ad = "Efekan", Soyad = "Yılmaz", TcNo = 94217503861, Sifre = 748302, Sınıf = "11-B", Aktif = "Evet" }

                );

            modelBuilder.Entity<Teacher>().HasData(

                new Teacher { Id = 1, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 2, Ad = "Meltem", Soyad = "Karadağ", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 3, Ad = "Pelin", Soyad = "Şendil", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 4, Ad = "Harun", Soyad = "Gürsoy", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 5, Ad = "Aslı", Soyad = "Gürel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 6, Ad = "Necmettin Alp", Soyad = "Ar", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 7, Ad = "Ebru", Soyad = "Şahin", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 8, Ad = "Özlem", Soyad = "Bayram", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 9, Ad = "Sinan", Soyad = "Vural", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 10, Ad = "Celil", Soyad = "Öztürk", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 11, Ad = "Barış", Soyad = "Bozan", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 12, Ad = "Güneş", Soyad = "Parlakgün", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 13, Ad = "Emel", Soyad = "Pülent", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 14, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 15, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 16, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 17, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 18, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 19, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 20, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 21, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 22, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 23, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 24, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 25, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 26, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 27, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 28, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 29, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 30, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 31, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 32, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 33, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 34, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 35, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 36, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 37, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
                new Teacher { Id = 38, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır" }
            );


        }
    }
}
