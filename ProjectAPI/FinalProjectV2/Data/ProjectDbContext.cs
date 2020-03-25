using FinalProjectV2.Data.Entities;
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
        public DbSet<ProductSpec> ProductSpecs { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<News> News { get; set; }
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
                new SubCategoryItem { Id = 15, Name = "Ekran qoruyucuları", PhotoPath = "screen_protector.jpg", SubCategoryId = 2 },
                new SubCategoryItem { Id = 16, Name = "DVD və BLUE-RAY pleyerlər", PhotoPath = "dvd_player.jpg", SubCategoryId = 3 },
                new SubCategoryItem { Id = 17, Name = "İPOD və MP3 pleyerlər", PhotoPath = "ipod.jpg", SubCategoryId = 3 },
                new SubCategoryItem { Id = 18, Name = "Televizorlar", PhotoPath = "tv.jpg", SubCategoryId = 3 },
                new SubCategoryItem { Id = 19, Name = "Noutbuklar", PhotoPath = "Laptops.jpg", SubCategoryId = 4 },
                new SubCategoryItem { Id = 20, Name = "Masaüstü kompüterlər", PhotoPath = "Desktops.jpg", SubCategoryId = 4 },
                new SubCategoryItem { Id = 21, Name = "Printerlər və çoxfunksiyalı avadanlıqlar", PhotoPath = "Printers.jpg", SubCategoryId = 5 },
                new SubCategoryItem { Id = 22, Name = "Monitorlar", PhotoPath = "Monitors.jpg", SubCategoryId = 5 },
                new SubCategoryItem { Id = 23, Name = "USB flash kartlar", PhotoPath = "usb_flash.jpg", SubCategoryId = 5 },
                new SubCategoryItem { Id = 24, Name = "Operativ yaddaşlar", PhotoPath = "memory_ram.jpg", SubCategoryId = 6 },
                new SubCategoryItem { Id = 25, Name = "Daxili sərt disklər (HDD)", PhotoPath = "hard_drivers.jpg", SubCategoryId = 6 },
                new SubCategoryItem { Id = 26, Name = "Xüsusi qələmlər", PhotoPath = "Styluses.jpg", SubCategoryId = 7 },
                new SubCategoryItem { Id = 27, Name = "Məlumat saxlama qurğuları", PhotoPath = "storage.jpg", SubCategoryId = 8 },
                new SubCategoryItem { Id = 28, Name = "Routerlər", PhotoPath = "Routers.jpg", SubCategoryId = 8 },
                new SubCategoryItem { Id = 29, Name = "Oyun konsolları", PhotoPath = "Consoles.jpg", SubCategoryId = 9 },
                new SubCategoryItem { Id = 30, Name = "Oyun nəzarətçiləri", PhotoPath = "controller.jpg", SubCategoryId = 9 },
                new SubCategoryItem { Id = 31, Name = "Video oyunlar", PhotoPath = "games.jpg", SubCategoryId = 9 },
                new SubCategoryItem { Id = 32, Name = "Fotokameralar", PhotoPath = "Cameras.jpg", SubCategoryId = 10 },
                new SubCategoryItem { Id = 33, Name = "Foto obyektivlər", PhotoPath = "Lenses.jpg", SubCategoryId = 10 },
                new SubCategoryItem { Id = 34, Name = "VideoKameralar", PhotoPath = "Camcorders.jpg", SubCategoryId = 10 },
                new SubCategoryItem { Id = 35, Name = "Soyuducular", PhotoPath = "Refrigerators.jpg", SubCategoryId = 11 },
                new SubCategoryItem { Id = 36, Name = "Qaz sobaları", PhotoPath = "gas.jpg", SubCategoryId = 11 },
                new SubCategoryItem { Id = 37, Name = "Ütülər", PhotoPath = "irons.jpg", SubCategoryId = 12 },
                new SubCategoryItem { Id = 38, Name = "Kondisionerlər", PhotoPath = "conditioners.jpg", SubCategoryId = 12 },
                new SubCategoryItem { Id = 39, Name = "Tərəzilər", PhotoPath = "Scales.jpg", SubCategoryId = 13 },
                new SubCategoryItem { Id = 40, Name = "Epilyatorlar", PhotoPath = "Epilators.jpg", SubCategoryId = 13 },
                new SubCategoryItem { Id = 41, Name = "Kişi ətirləri", PhotoPath = "men.jpg", SubCategoryId = 14 },
                new SubCategoryItem { Id = 42, Name = "Qadın ətirləri", PhotoPath = "women.jpg", SubCategoryId = 14 },
                new SubCategoryItem { Id = 43, Name = "Masa örtüyü", PhotoPath = "masa.jpg", SubCategoryId = 15 },
                new SubCategoryItem { Id = 44, Name = "Mətbəx tekstili", PhotoPath = "kitchen.jpg", SubCategoryId = 15 },
                new SubCategoryItem { Id = 45, Name = "Qabyuyan aksessuarları", PhotoPath = "dish_acss.jpg", SubCategoryId = 16 },
                new SubCategoryItem { Id = 46, Name = "Qazanlar və tavalar", PhotoPath = "dishes.jpg", SubCategoryId = 16 },
                new SubCategoryItem { Id = 47, Name = "İş lampaları", PhotoPath = "lamp.jpg", SubCategoryId = 17 },
                new SubCategoryItem { Id = 48, Name = "Kreslolar", PhotoPath = "kreslo.jpg", SubCategoryId = 17 });
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
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1 , Name = "Apple iPhone 11 Pro Dual SIM 64GB Midnight Green" , MainPhoto = "iphone.jpg" , Price = 1200 , SalePercent = 20 , SubCategoryItemsId = 1 },
                new Product { Id = 2 , Name = "Samsung Galaxy A20s Dual Sim SM - A207F / DS 32GB 4G LTE Red" , MainPhoto = "samsungphone.jpg" , Price = 1400 , SubCategoryItemsId = 2 },
                new Product { Id = 3 , Name = "Honor 8C Dual BKK-LX2 3GB/32GB 4G LTE Black", MainPhoto = "huaweiphone.jpg" , Price = 160 , SalePercent = 14 , SubCategoryItemsId = 3 },
                new Product { Id = 4 , Name = "Xiaomi Mi Note 10 Pro Dual M1910F4S 8GB/256GB 4G LTE", MainPhoto = "xiaomiphone.jpg" , Price = 455 , SubCategoryItemsId = 4 },
                new Product { Id = 5 , Name = "Nokia 2.2 Dual TA-1188 2GB/16GB 4G LTE Black", MainPhoto = "nokiaphone.jpg" , Price = 93 , SubCategoryItemsId = 5 },
                new Product { Id = 6 , Name = "LG V30 Dual H930D 64GB 4G LTE Black", MainPhoto = "lgphone.jpg" , Price = 300 , SubCategoryItemsId = 6 },
                new Product { Id = 7 , Name = "Panasonic Eluga A3 Dual 16GB 4G LTE Gold", MainPhoto = "panasonicphone.jpg" , Price = 164 , SalePercent = 34 , SubCategoryItemsId = 7 },
                new Product { Id = 8 , Name = "Realme 5 Pro Dual RMX1971 4GB/128GB 4G LTE Sparking", MainPhoto = "realmephone.jpg" , Price = 200 , SubCategoryItemsId = 8 },
                new Product { Id = 9 , Name = "Honor 8A Pro Dual JAT-L41 3GB/64GB 4G LTE Blue", MainPhoto = "honorphone.jpg" , Price = 430 , SalePercent = 12 , SubCategoryItemsId = 9 },
                new Product { Id = 10 , Name = "Cat B25 Dual SIM Black", MainPhoto = "caterpillarphone.jpg" , Price = 59 , SubCategoryItemsId = 10 },
                new Product { Id = 11, Name = "Motorola One Macro Dual PAGS0005IN 4GB/64GB 4G LTE", MainPhoto = "motorolaphone.jpg", Price = 152, SubCategoryItemsId = 11 },
                new Product { Id = 12 , Name = "X-Doria iPhone XS/X Case Defense Defense Shield Rose", MainPhoto = "phonecase.jpg" , Price = 16 , SubCategoryItemsId = 12 },
                new Product { Id = 13 , Name = "Samsung Galaxy Watch Active 2 44mm Bluetooth Smartwatch", MainPhoto = "smartwatch.jpg" , Price = 335 , SubCategoryItemsId = 13 },
                new Product { Id = 14 , Name = "JBL TUNE 500BT Wireless On-Ear Headphones (Blue)", MainPhoto = "jbl.jpg" , Price = 52 , SalePercent = 4 , SubCategoryItemsId = 14 },
                new Product { Id = 15 , Name = "Ferrari Off Track Tempered Glass with Invisible Logo for iPhone Xs", MainPhoto = "phoneglass.jpg" , Price = 5 , SubCategoryItemsId = 15 },
                new Product { Id = 16 , Name = "Apple TV 4K 32GB (MQD22)", MainPhoto = "appletv.jpg" , Price = 199 , SubCategoryItemsId = 16 },
                new Product { Id = 17 , Name = "Apple iPod touch 32GB 7th Generation (Pink)", MainPhoto = "appleipod.jpg" , Price = 239 , SubCategoryItemsId = 17 },
                new Product { Id = 18 , Name = "LG 43-Inch 4K UHD TV 43UK6400 Black", MainPhoto = "lgtv.jpg" , Price = 400 , SalePercent = 7 , SubCategoryItemsId = 18 },
                new Product { Id = 19 , Name = "ASUS ROG Zephyrus GX701GXR-HG122T Gaming", MainPhoto = "asuscomp.jpg" , Price = 3740 , SubCategoryItemsId = 19 },
                new Product { Id = 20 , Name = "Apple iMac Pro 27 MQ2Y2 with Retina 5K Display(Late 2017)", MainPhoto = "imac.jpg" , Price =5000 , SubCategoryItemsId = 20 },
                new Product { Id = 21 , Name = "HP ScanJet Pro 2500 f1 (L2747A)", MainPhoto = "hpprint.jpg" , Price = 330 , SubCategoryItemsId = 21 },
                new Product { Id = 22 , Name = "HP 32s Monitor 2UD96AA Black/Silver", MainPhoto = "hpmon.jpg" , Price = 285 , SubCategoryItemsId = 22 },
                new Product { Id = 23 , Name = "SanDisk iXpand Flash Drive for iPhone and iPad (64GB)", MainPhoto = "sandisk.jpg" , Price = 78 , SubCategoryItemsId = 23 }
                );
            modelBuilder.Entity<ProductSpec>()
            .HasKey(bc => new { bc.SpecificationId, bc.ProductId });
            modelBuilder.Entity<ProductSpec>()
                .HasOne(bc => bc.Specification)
                .WithMany(b => b.ProductSpecs)
                .HasForeignKey(bc => bc.SpecificationId);
            modelBuilder.Entity<ProductSpec>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.ProductSpecs)
                .HasForeignKey(bc => bc.ProductId);
        }
        public DbSet<FinalProjectV2.Data.Entities.Specification> Specification { get; set; }
        public DbSet<FinalProjectV2.Data.Entities.ProductSpec> ProductSpec { get; set; }
    }
}
