﻿using Microsoft.AspNetCore.Mvc.Infrastructure;
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
        public DbSet<Class> Clases { get; set; }

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
                new Student { Id = 11, Ad = "Rabia", Soyad = "Erdogan", TcNo = 72954018365, Sifre = 905432, Sınıf = "11-B", Aktif = "Evet" },
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
                /*
                 * Altta gördüğümüz api Öğretmen apisidir api baya dolu ve biraz karmaşıktır 
                 */

                new Teacher { Id = 1, Ad = "Ömer", Soyad = "Yüksel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür", Cinsiyet = "Erkek", OturduguIlce = "Beyoğlu", Aktif = "Hayır", AddDate = DateTime.Now, Sifre = "ru7t8vp9mbtjy" },
                new Teacher { Id = 2, Ad = "Meltem", Soyad = "Karadağ", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür Yardımcısı", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "bm-912*45" },
                new Teacher { Id = 3, Ad = "Pelin", Soyad = "Şendil", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müdür Yardımcısı", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "b70n285693" },
                new Teacher { Id = 4, Ad = "Harun", Soyad = "Gürsoy", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Erkek", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "2b7890n63" },
                new Teacher { Id = 5, Ad = "Aslı", Soyad = "Gürel", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "b2605937b5" },
                new Teacher { Id = 6, Ad = "Necmettin Alp", Soyad = "Ar", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Erkek", OturduguIlce = "Sancaktepe", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "v783vtt49vut" },
                new Teacher { Id = 7, Ad = "Ebru", Soyad = "Şahin", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "07vn2653489" },
                new Teacher { Id = 8, Ad = "Özlem", Soyad = "Bayram", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "8o59un" },
                new Teacher { Id = 9, Ad = "Sinan", Soyad = "Vural", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Erkek", OturduguIlce = "Ataşehir", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "4t1654" },
                new Teacher { Id = 10, Ad = "Celil", Soyad = "Öztürk", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Erkek", OturduguIlce = "Ataşehir", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "274v890" },
                new Teacher { Id = 11, Ad = "Barış", Soyad = "Bozan", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Erkek", OturduguIlce = "Ataşehir", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "b265379n0" },
                new Teacher { Id = 12, Ad = "Güneş", Soyad = "Parlakgün", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Bilişim Teknolojileri Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "oyurhpg" },
                new Teacher { Id = 13, Ad = "Emel", Soyad = "Pülent", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Halkla İlişkiler ve Organizasyon Hizmetleri", Cinsiyet = "Kadın", OturduguIlce = "Ümraniye", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "b46v7*4m1n" },
                new Teacher { Id = 14, Ad = "Aslı", Soyad = "Taban", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Halkla İlişkiler ve Organizasyon Hizmetleri", Cinsiyet = "Kadın", OturduguIlce = "Ümraniye", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "34v186um0*" },
                new Teacher { Id = 15, Ad = "Gökhan", Soyad = "Güngör", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Halkla İlişkiler ve Organizasyon Hizmetleridür", Cinsiyet = "Erkek", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "4v618j90*" },
                new Teacher { Id = 16, Ad = "Yunus Kaan", Soyad = "Özkan", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Halkla İlişkiler ve Organizasyon Hizmetleri", Cinsiyet = "Erkek", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "7854vj2c" },
                new Teacher { Id = 17, Ad = "Gülay Tokgöz", Soyad = "Kanmaz", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Edebiyat Öğretmeni", Cinsiyet = "Erkek", OturduguIlce = "Ümraniye", Aktif = "HaEvetyır", AddDate = DateTime.Now, Sifre = "5y907n36" },
                new Teacher { Id = 18, Ad = "Nazife", Soyad = "Kaçar", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Edebiyat Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "vy4t97" },
                new Teacher { Id = 19, Ad = "Özlem", Soyad = "Koşal", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Edebiyat Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "7mıu9*" },
                new Teacher { Id = 20, Ad = "Sema Deniz", Soyad = "Yolsal", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Edebiyat Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Sancaktepe", Aktif = "Hayır", AddDate = DateTime.Now, Sifre = "b6n4b89" },
                new Teacher { Id = 21, Ad = "Dilek", Soyad = "Erbil", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Matematik Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "5b07n8639" },
                new Teacher { Id = 22, Ad = "Işık Kutlu", Soyad = "Çalışkan", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Matematik Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Ümraniye", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "m98n07*ö" },
                new Teacher { Id = 23, Ad = "Züleyha", Soyad = "Atmaca", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Tarih Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = " 5n76y9" },
                new Teacher { Id = 24, Ad = "Zehra", Soyad = "Taşçı", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Tarih Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "b6v954n" },
                new Teacher { Id = 25, Ad = "Nejla", Soyad = "Yılmaz", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Coğrafya Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Üsküdar", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "ö98m05v34268" },
                new Teacher { Id = 26, Ad = "Serpil", Soyad = "Gültepe", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Fizik Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Ataşehir", Aktif = "Evet", AddDate = DateTime.Now, Sifre = " 7n438569" },
                new Teacher { Id = 27, Ad = "Merve", Soyad = "Tamtürk", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Kimya Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Üsküdar", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "qb5wbree ef" },
                new Teacher { Id = 28, Ad = "Engin", Soyad = "Keklil", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Biyoloji Öğretmeni", Cinsiyet = "Erkek", OturduguIlce = "Üsküdar", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "1cx23w4" },
                new Teacher { Id = 29, Ad = "Şeyda Gülsün", Soyad = "Tangör", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "İngilizce Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Üsküdar", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "867b4b645" },
                new Teacher { Id = 30, Ad = "Hande Fatma", Soyad = "Ocak", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "İngilizce Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "hsljşgdefk" },
                new Teacher { Id = 31, Ad = "Hatice Handan", Soyad = "Şimşek", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Felsefe Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "7b5n096" },
                new Teacher { Id = 32, Ad = "Muteber", Soyad = "Demirkale", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Beden Eğitimi Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Ümraniye", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "7b5n38" },
                new Teacher { Id = 33, Ad = "Süheyla", Soyad = "Subay", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Müzik Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "6v62915843" },
                new Teacher { Id = 34, Ad = "Esma", Soyad = "Kaymak", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Din Kült. ve Ahl.Bil. Öğretmeni", Cinsiyet = "Kadın", OturduguIlce = "Ataşehir", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "537b98y4t5" },
                new Teacher { Id = 35, Ad = "Hasan", Soyad = "Yeşilyurt", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Din Kült. ve Ahl.Bil. Öğretmeni", Cinsiyet = "Erkek", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "b6v5t4398" },
                new Teacher { Id = 36, Ad = "Songül", Soyad = "Ataç", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Psikolojik Danışman", Cinsiyet = "Kadın", OturduguIlce = "Üsküdar", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "bv6428t" },
                new Teacher { Id = 37, Ad = "Zeynep", Soyad = "Biter", TelefonNo = "+90 5__ ___ __ __", UzmanlıkAlanıDersler = "Psikolojik Danışman", Cinsiyet = "Kadın", OturduguIlce = "Kadıköy", Aktif = "Evet", AddDate = DateTime.Now, Sifre = "8u08b9ny" }
            );

            modelBuilder.Entity<Class>().HasData(

                //Burası sınıf apilerinin tutulduğu DataBase Context bölümüdür

                new Class { Id =8,  SınıfAdı ="10/C", Mevcut=22 ,OgretmenID=24, Aktif = "Evet" },
                new Class { Id =1,  SınıfAdı ="12/A", Mevcut=23 ,OgretmenID=17, Aktif = "Evet" },
                new Class { Id =2,  SınıfAdı ="12/AH",Mevcut=11 ,OgretmenID=14, Aktif = "Evet" },
                new Class { Id =3,  SınıfAdı ="11/A", Mevcut=26 ,OgretmenID=21, Aktif = "Evet" },
                new Class { Id =4,  SınıfAdı ="11/B", Mevcut=27 ,OgretmenID=31, Aktif = "Evet" },
                new Class { Id =5,  SınıfAdı ="11/AH",Mevcut=10 ,OgretmenID=13, Aktif = "Evet" },
                new Class { Id =6,  SınıfAdı ="10/A", Mevcut=23 ,OgretmenID=4,  Aktif = "Evet" },
                new Class { Id =7,  SınıfAdı ="10/B", Mevcut=25 ,OgretmenID=9,  Aktif = "Evet" },
                new Class { Id =9,  SınıfAdı ="10/AH",Mevcut=15 ,OgretmenID=15, Aktif = "Evet" },
                new Class { Id =10, SınıfAdı ="9/A",  Mevcut=24 ,OgretmenID=28, Aktif = "Evet" },
                new Class { Id =11, SınıfAdı ="9/B",  Mevcut=26 ,OgretmenID=30, Aktif = "Evet" },
                new Class { Id =12, SınıfAdı ="9/C",  Mevcut=25 ,OgretmenID=34, Aktif = "Evet" },
                new Class { Id =13, SınıfAdı ="9/AH", Mevcut=18 ,OgretmenID=16, Aktif = "Evet" }
            );
        }
    }
}
