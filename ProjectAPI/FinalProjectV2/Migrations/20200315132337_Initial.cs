using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectV2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertisementSliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisterModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Surname = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 300, nullable: false),
                    Link = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoryItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 250, nullable: false),
                    SubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoryItems_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Markas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SubCategoryItemsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Markas_SubCategoryItems_SubCategoryItemsId",
                        column: x => x.SubCategoryItemsId,
                        principalTable: "SubCategoryItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    MainPhoto = table.Column<string>(maxLength: 250, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    SalePercent = table.Column<byte>(nullable: false),
                    GuaranteeDate = table.Column<byte>(nullable: false),
                    GuaranteePrice = table.Column<byte>(nullable: false),
                    Condition = table.Column<string>(maxLength: 30, nullable: false),
                    ShipDate = table.Column<string>(maxLength: 30, nullable: false),
                    ShipPrice = table.Column<byte>(nullable: false),
                    TestDate = table.Column<byte>(nullable: false),
                    Specification = table.Column<string>(maxLength: 800, nullable: false),
                    SubCategoryItemsId = table.Column<int>(nullable: false),
                    IsInBasket = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategoryItems_SubCategoryItemsId",
                        column: x => x.SubCategoryItemsId,
                        principalTable: "SubCategoryItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    MarkaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Markas_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Markas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(maxLength: 300, nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ELEKTRONIKA" },
                    { 2, "KOMPÜTERLƏR" },
                    { 3, "OYUNLAR" },
                    { 4, "FOTO VƏ VİDEO" },
                    { 5, "MƏİŞƏT AVANDANLIQLARI" },
                    { 6, "PARFÜM VƏ KOSMETİKA" },
                    { 7, "EV ƏŞYALARI" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "PhoneNumber" },
                values: new object[] { 1, "aykhanzd@code.edu.az", "+994556550511" });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "Link", "Photo" },
                values: new object[,]
                {
                    { 1, "#", "google.png" },
                    { 2, "#", "facebook.png" },
                    { 3, "#", "twitter.png" },
                    { 4, "#", "vk.png" },
                    { 5, "#", "watsup.png" },
                    { 6, "https://www.instagram.com/ay.xan11/", "instagram.png" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Telefonlar" },
                    { 15, 7, "Tekstil" },
                    { 14, 6, "Ətriyyat" },
                    { 13, 5, "Gözəllik məhsulları" },
                    { 12, 5, "Məişət avadanlıqları" },
                    { 11, 5, "Mətbəx avadanlıqları" },
                    { 10, 4, "Foto aksessuarları" },
                    { 16, 7, "Qab-qacaq" },
                    { 9, 3, "Oyun" },
                    { 7, 2, "Tabletlər üçün üzlüklər və qapaqlar" },
                    { 6, 2, "Kompüter ehtiyyat hissələri" },
                    { 5, 2, "Periferiya qurğuları" },
                    { 4, 2, "Kompüter" },
                    { 3, 1, "TV və audio" },
                    { 2, 1, "Mobil aksessuarlar" },
                    { 8, 2, "Şəbəkə avadanlığı" },
                    { 17, 7, "Ofis mebeli" }
                });

            migrationBuilder.InsertData(
                table: "SubCategoryItems",
                columns: new[] { "Id", "Name", "PhotoPath", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, "APPLE", "apple.jpg", 1 },
                    { 30, "Operativ yaddaşlar", "memory_ram.jpg", 6 },
                    { 31, "Daxili sərt disklər (HDD)", "hard_drivers.jpg", 6 },
                    { 32, "Xüsusi qələmlər", "Styluses.jpg", 7 },
                    { 33, "Məlumat saxlama qurğuları", "storage.jpg", 8 },
                    { 34, "Routerlər", "Routers.jpg", 8 },
                    { 35, "Oyun konsolları", "Consoles.jpg", 9 },
                    { 36, "Oyun nəzarətçiləri", "controller.jpg", 9 },
                    { 37, "Video oyunlar", "games.jpg", 9 },
                    { 38, "Fotokameralar", "Cameras.jpg", 10 },
                    { 39, "Foto obyektivlər", "Lenses.jpg", 10 },
                    { 40, "VideoKameralar", "Camcorders.jpg", 10 },
                    { 41, "Soyuducular", "Refrigerators.jpg", 11 },
                    { 42, "Qaz sobaları", "gas.jpg", 11 },
                    { 43, "Ütülər", "irons.jpg", 12 },
                    { 44, "Kondisionerlər", "conditioners.jpg", 12 },
                    { 45, "Tərəzilər", "Scales.jpg", 13 },
                    { 46, "Epilyatorlar", "Epilators.jpg", 13 },
                    { 47, "Kişi ətirləri", "men.jpg", 14 },
                    { 48, "Qadın ətirləri", "women.jpg", 14 },
                    { 49, "Masa örtüyü", "masa.jpg", 15 },
                    { 50, "Mətbəx tekstili", "kitchen.jpg", 15 },
                    { 51, "Qabyuyan aksessuarları", "dish_acss.jpg", 16 },
                    { 52, "Qazanlar və tavalar", "dishes.jpg", 16 },
                    { 29, "USB flash kartlar", "usb_flash.jpg", 5 },
                    { 28, "Monitorlar", "Monitors.jpg", 5 },
                    { 27, "Printerlər və çoxfunksiyalı avadanlıqlar", "Printers.jpg", 5 },
                    { 26, "Masaüstü kompüterlər", "Desktops.jpg", 4 },
                    { 2, "SAMSUNG", "samsung.jpg", 1 },
                    { 3, "HUAWEI", "huawei.jpg", 1 },
                    { 4, "XIAOMI", "xiaomi.jpg", 1 },
                    { 5, "NOKIA", "nokia.jpg", 1 },
                    { 6, "LG", "lg.jpg", 1 },
                    { 7, "PANASONIC", "panasonic.jpg", 1 },
                    { 8, "REALME", "realme.jpg", 1 },
                    { 9, "HONOR", "honor.jpg", 1 },
                    { 10, "CATERPILLAR", "caterpillar.jpg", 1 },
                    { 11, "MOTOROLA", "motorola.jpg", 1 },
                    { 12, "Örtük və qutular", "case.jpg", 2 },
                    { 53, "İş lampaları", "lamp.jpg", 17 },
                    { 13, "Smart saatlar", "smart_watch.jpg", 2 },
                    { 15, "Sport bilərzikləri", "fit_watch.jpg", 2 },
                    { 16, "Enerji bankları", "portable_charger.jpg", 2 },
                    { 17, "Portativ səs qurğular", "speaker.jpg", 2 },
                    { 18, "Adapterlər", "charger.jpg", 2 },
                    { 19, "Selfi çubuqları", "selfie.jpg", 2 },
                    { 20, "Ekran qoruyucuları", "screen_protector.jpg", 2 },
                    { 21, "Kabel və adapterlər", "cable.jpg", 2 },
                    { 22, "DVD və BLUE-RAY pleyerlər", "dvd_player.jpg", 3 },
                    { 23, "İPOD və MP3 pleyerlər", "ipod.jpg", 3 },
                    { 24, "Televizorlar", "tv.jpg", 3 },
                    { 25, "Noutbuklar", "Laptops.jpg", 4 },
                    { 14, "Qulaqcıqlar", "headsets.jpg", 2 },
                    { 54, "Kreslolar", "kreslo.jpg", 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Markas_SubCategoryItemsId",
                table: "Markas",
                column: "SubCategoryItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_MarkaId",
                table: "Models",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryItemsId",
                table: "Products",
                column: "SubCategoryItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryItems_SubCategoryId",
                table: "SubCategoryItems",
                column: "SubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertisementSliders");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "LoginModels");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "RegisterModels");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropTable(
                name: "Markas");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategoryItems");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
