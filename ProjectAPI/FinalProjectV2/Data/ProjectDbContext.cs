using Microsoft.EntityFrameworkCore;
using ProjectAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext()
        {

        }
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AdvertisementSlider> AdvertisementSliders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }
        public DbSet<RegisterModel> RegisterModels { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubCategoryItem> SubCategoryItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1 , Name = "ELEKTRONIKA" },
                new Category { Id = 2 , Name = "KOMPÜTERLƏR" },
                new Category { Id = 3 , Name = "OYUNLAR" },
                new Category { Id = 4 , Name = "FOTO VƏ VİDEO" },
                new Category { Id = 5 , Name = "MƏİŞƏT AVANDANLIQLARI" },
                new Category { Id = 6 , Name = "PARFÜM VƏ KOSMETİKA" },
                new Category { Id = 7 , Name = "EV ƏŞYALARI" }
                );
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory { Id = 1 , Name = "Telefonlar", CategoryId = 1 },
                new SubCategory { Id = 2 , Name = "Mobil aksessuarlar", CategoryId = 1 },
                new SubCategory { Id = 3 , Name = "TV və audio", CategoryId = 1 },
                new SubCategory { Id = 4 , Name = "Kompüter", CategoryId = 2 },
                new SubCategory { Id = 5 , Name = "Periferiya qurğuları", CategoryId = 2 },
                new SubCategory { Id = 6 , Name = "Kompüter ehtiyyat hissələri", CategoryId = 2 },
                new SubCategory { Id = 7 , Name = "Tabletlər üçün üzlüklər və qapaqlar", CategoryId = 2 },
                new SubCategory { Id = 8 , Name = "Şəbəkə avadanlığı", CategoryId = 2 },
                new SubCategory { Id = 9 , Name = "Oyun", CategoryId = 3 },
                new SubCategory { Id = 10 , Name = "Foto aksessuarları", CategoryId = 4 },
                new SubCategory { Id = 11 , Name = "Mətbəx avadanlıqları", CategoryId = 5 },
                new SubCategory { Id = 12, Name = "Məişət avadanlıqları", CategoryId = 5 },
                new SubCategory { Id = 13 , Name = "Gözəllik məhsulları", CategoryId = 5 },
                new SubCategory { Id = 14 , Name = "Ətriyyat", CategoryId = 6 },
                new SubCategory { Id = 15 , Name = "Tekstil", CategoryId = 7 },
                new SubCategory { Id = 16 , Name = "Qab-qacaq", CategoryId = 7 },
                new SubCategory { Id = 17 , Name = "Ofis mebeli", CategoryId = 7 }
                );
            _ = modelBuilder.Entity<SubCategoryItem>().HasData(
                new SubCategoryItem { Id = 1, Name = "APPLE", PhotoPath = "apple.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 2, Name = "SAMSUNG", PhotoPath = "samsung.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 3, Name = "HUAWEI", PhotoPath = "huawei.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 4, Name = "XIAOMI", PhotoPath = "xiaomi.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 5, Name = "NOKIA", PhotoPath = "nokia.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 6, Name = "LG", PhotoPath = "lg.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 7, Name = "PANASONIC", PhotoPath = "panasonic.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 8, Name = "REALME", PhotoPath = "realme.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 9, Name = "HONOR", PhotoPath = "honor.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 10, Name = "CATERPILLAR", PhotoPath = "caterpillar.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 11, Name = "MOTOROLA", PhotoPath = "motorola.jpg", SubCategoryId = 1 },
                new SubCategoryItem { Id = 12, Name = "Örtük və qutular", PhotoPath = "case.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 13, Name = "Smart saatlar", PhotoPath = "smart_watch.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 14, Name = "Qulaqcıqlar", PhotoPath = "headsets.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 15, Name = "Sport bilərzikləri", PhotoPath = "fit_watch.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 16, Name = "Enerji bankları", PhotoPath = "portable_charger.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 17, Name = "Portativ səs qurğular", PhotoPath = "speaker.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 18, Name = "Adapterlər", PhotoPath = "charger.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 19, Name = "Selfi çubuqları", PhotoPath = "selfie.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 20, Name = "Ekran qoruyucuları", PhotoPath = "screen_protector.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 21, Name = "Kabel və adapterlər", PhotoPath = "cable.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 22, Name = "DVD və BLUE-RAY pleyerlər", PhotoPath = "dvd_player.jpg", SubCategoryId = 3 },
                new SubCategoryItem { Id = 23, Name = "İPOD və MP3 pleyerlər", PhotoPath = "ipod.jpg", SubCategoryId = 3 },
                new SubCategoryItem { Id = 24, Name = "Televizorlar", PhotoPath = "tv.jpg", SubCategoryId = 3 },
                new SubCategoryItem { Id = 25, Name = "Noutbuklar", PhotoPath = "Laptops.jpg", SubCategoryId = 4 },
                new SubCategoryItem { Id = 26, Name = "Masaüstü kompüterlər", PhotoPath = "Desktops.jpg", SubCategoryId = 4 },
                new SubCategoryItem { Id = 27, Name = "Printerlər və çoxfunksiyalı avadanlıqlar", PhotoPath = "Printers.jpg", SubCategoryId = 5 },
                new SubCategoryItem { Id = 28, Name = "Monitorlar", PhotoPath = "Monitors.jpg", SubCategoryId = 5 },
                new SubCategoryItem { Id = 29, Name = "USB flash kartlar", PhotoPath = "usb_flash.jpg", SubCategoryId = 5 },
                new SubCategoryItem { Id = 30, Name = "Operativ yaddaşlar", PhotoPath = "memory_ram.jpg", SubCategoryId = 6 },
                new SubCategoryItem { Id = 31, Name = "Daxili sərt disklər (HDD)", PhotoPath = "hard_drivers.jpg", SubCategoryId = 6 },
                new SubCategoryItem { Id = 32, Name = "Xüsusi qələmlər", PhotoPath = "Styluses.jpg", SubCategoryId = 7 },
                new SubCategoryItem { Id = 33, Name = "Məlumat saxlama qurğuları", PhotoPath = "storage.jpg", SubCategoryId = 8 },
                new SubCategoryItem { Id = 34, Name = "Routerlər", PhotoPath = "Routers.jpg", SubCategoryId = 8 },
                new SubCategoryItem { Id = 35, Name = "Oyun konsolları", PhotoPath = "Consoles.jpg", SubCategoryId = 9 },
                new SubCategoryItem { Id = 36, Name = "Oyun nəzarətçiləri", PhotoPath = "controller.jpg", SubCategoryId = 9 },
                new SubCategoryItem { Id = 37, Name = "Video oyunlar", PhotoPath = "games.jpg", SubCategoryId = 9 },
                new SubCategoryItem { Id = 38, Name = "Fotokameralar", PhotoPath = "Cameras.jpg", SubCategoryId = 10 },
                new SubCategoryItem { Id = 39, Name = "Foto obyektivlər", PhotoPath = "Lenses.jpg", SubCategoryId = 10 },
                new SubCategoryItem { Id = 40, Name = "VideoKameralar", PhotoPath = "Camcorders.jpg", SubCategoryId = 10 },
                new SubCategoryItem { Id = 41, Name = "Soyuducular", PhotoPath = "Refrigerators.jpg", SubCategoryId = 11 },
                new SubCategoryItem { Id = 42, Name = "Qaz sobaları", PhotoPath = "gas.jpg", SubCategoryId = 11 },
                new SubCategoryItem { Id = 43, Name = "Ütülər", PhotoPath = "irons.jpg", SubCategoryId = 12 },
                new SubCategoryItem { Id = 44, Name = "Kondisionerlər", PhotoPath = "conditioners.jpg", SubCategoryId = 12 },
                new SubCategoryItem { Id = 45, Name = "Tərəzilər", PhotoPath = "Scales.jpg", SubCategoryId = 13 },
                new SubCategoryItem { Id = 46, Name = "Epilyatorlar", PhotoPath = "Epilators.jpg", SubCategoryId = 13 },
                new SubCategoryItem { Id = 47, Name = "Kişi ətirləri", PhotoPath = "men.jpg", SubCategoryId = 14 },
                new SubCategoryItem { Id = 48, Name = "Qadın ətirləri", PhotoPath = "women.jpg", SubCategoryId = 14 },
                new SubCategoryItem { Id = 49, Name = "Masa örtüyü", PhotoPath = "masa.jpg", SubCategoryId = 15 },
                new SubCategoryItem { Id = 50, Name = "Mətbəx tekstili", PhotoPath = "kitchen.jpg", SubCategoryId = 15 },
                new SubCategoryItem { Id = 51, Name = "Qabyuyan aksessuarları", PhotoPath = "dish_acss.jpg", SubCategoryId = 16 },
                new SubCategoryItem { Id = 52, Name = "Qazanlar və tavalar", PhotoPath = "dishes.jpg", SubCategoryId = 16 },
                new SubCategoryItem { Id = 53, Name = "İş lampaları", PhotoPath = "lamp.jpg", SubCategoryId = 17 },
                new SubCategoryItem { Id = 54, Name = "Kreslolar", PhotoPath = "kreslo.jpg", SubCategoryId = 17 });
            modelBuilder.Entity<Social>().HasData(
                new Social { Id = 1 , Link = "#" , Photo = "google.png" },
                new Social { Id = 2 , Link = "#" , Photo = "facebook.png" },
                new Social { Id = 3 , Link = "#" , Photo = "twitter.png" },
                new Social { Id = 4 , Link = "#" , Photo = "vk.png" },
                new Social { Id = 5 , Link = "#" , Photo = "watsup.png" },
                new Social { Id = 6 , Link = "https://www.instagram.com/ay.xan11/", Photo = "instagram.png" }
                );
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1 , Email = "aykhanzd@code.edu.az" , PhoneNumber = "+994556550511" }
                );
        }
    }
}
