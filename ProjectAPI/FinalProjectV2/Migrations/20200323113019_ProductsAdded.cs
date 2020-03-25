using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectV2.Migrations
{
    public partial class ProductsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800);

            migrationBuilder.AlterColumn<string>(
                name: "ShipDate",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Condition", "GuaranteeDate", "GuaranteePrice", "IsInBasket", "MainPhoto", "Name", "Price", "SalePercent", "ShipDate", "ShipPrice", "Specification", "SubCategoryItemsId", "TestDate" },
                values: new object[,]
                {
                    { 1, null, (byte)0, (byte)0, false, "iphone.jpg", "Apple iPhone 11 Pro Dual SIM 64GB Midnight Green", 1200m, (byte)20, null, (byte)0, null, 1, (byte)0 },
                    { 23, null, (byte)0, (byte)0, false, "sandisk.jpg", "SanDisk iXpand Flash Drive for iPhone and iPad (64GB)", 78m, (byte)0, null, (byte)0, null, 23, (byte)0 },
                    { 22, null, (byte)0, (byte)0, false, "hpmon.jpg", "HP 32s Monitor 2UD96AA Black/Silver", 285m, (byte)0, null, (byte)0, null, 22, (byte)0 },
                    { 21, null, (byte)0, (byte)0, false, "hpprint.jpg", "HP ScanJet Pro 2500 f1 (L2747A)", 330m, (byte)0, null, (byte)0, null, 21, (byte)0 },
                    { 20, null, (byte)0, (byte)0, false, "imac.jpg", "Apple iMac Pro 27 MQ2Y2 with Retina 5K Display(Late 2017)", 5000m, (byte)0, null, (byte)0, null, 20, (byte)0 },
                    { 19, null, (byte)0, (byte)0, false, "asuscomp.jpg", "ASUS ROG Zephyrus GX701GXR-HG122T Gaming", 3740m, (byte)0, null, (byte)0, null, 19, (byte)0 },
                    { 18, null, (byte)0, (byte)0, false, "lgtv.jpg", "LG 43-Inch 4K UHD TV 43UK6400 Black", 400m, (byte)7, null, (byte)0, null, 18, (byte)0 },
                    { 17, null, (byte)0, (byte)0, false, "appleipod.jpg", "Apple iPod touch 32GB 7th Generation (Pink)", 239m, (byte)0, null, (byte)0, null, 17, (byte)0 },
                    { 16, null, (byte)0, (byte)0, false, "appletv.jpg", "Apple TV 4K 32GB (MQD22)", 199m, (byte)0, null, (byte)0, null, 16, (byte)0 },
                    { 15, null, (byte)0, (byte)0, false, "phoneglass.jpg", "Ferrari Off Track Tempered Glass with Invisible Logo for iPhone Xs", 5m, (byte)0, null, (byte)0, null, 15, (byte)0 },
                    { 13, null, (byte)0, (byte)0, false, "smartwatch.jpg", "Samsung Galaxy Watch Active 2 44mm Bluetooth Smartwatch", 335m, (byte)0, null, (byte)0, null, 13, (byte)0 },
                    { 14, null, (byte)0, (byte)0, false, "jbl.jpg", "JBL TUNE 500BT Wireless On-Ear Headphones (Blue)", 52m, (byte)4, null, (byte)0, null, 14, (byte)0 },
                    { 11, null, (byte)0, (byte)0, false, "motorolaphone.jpg", "Motorola One Macro Dual PAGS0005IN 4GB/64GB 4G LTE", 152m, (byte)0, null, (byte)0, null, 11, (byte)0 },
                    { 10, null, (byte)0, (byte)0, false, "caterpillarphone.jpg", "Cat B25 Dual SIM Black", 59m, (byte)0, null, (byte)0, null, 10, (byte)0 },
                    { 9, null, (byte)0, (byte)0, false, "honorphone.jpg", "Honor 8A Pro Dual JAT-L41 3GB/64GB 4G LTE Blue", 430m, (byte)12, null, (byte)0, null, 9, (byte)0 },
                    { 8, null, (byte)0, (byte)0, false, "realmephone.jpg", "Realme 5 Pro Dual RMX1971 4GB/128GB 4G LTE Sparking", 200m, (byte)0, null, (byte)0, null, 8, (byte)0 },
                    { 7, null, (byte)0, (byte)0, false, "panasonicphone.jpg", "Panasonic Eluga A3 Dual 16GB 4G LTE Gold", 164m, (byte)34, null, (byte)0, null, 7, (byte)0 },
                    { 6, null, (byte)0, (byte)0, false, "lgphone.jpg", "LG V30 Dual H930D 64GB 4G LTE Black", 300m, (byte)0, null, (byte)0, null, 6, (byte)0 },
                    { 5, null, (byte)0, (byte)0, false, "nokiaphone.jpg", "Nokia 2.2 Dual TA-1188 2GB/16GB 4G LTE Black", 93m, (byte)0, null, (byte)0, null, 5, (byte)0 },
                    { 4, null, (byte)0, (byte)0, false, "xiaomiphone.jpg", "Xiaomi Mi Note 10 Pro Dual M1910F4S 8GB/256GB 4G LTE", 455m, (byte)0, null, (byte)0, null, 4, (byte)0 },
                    { 3, null, (byte)0, (byte)0, false, "huaweiphone.jpg", "Honor 8C Dual BKK-LX2 3GB/32GB 4G LTE Black", 160m, (byte)14, null, (byte)0, null, 3, (byte)0 },
                    { 2, null, (byte)0, (byte)0, false, "samsungphone.jpg", "Samsung Galaxy A20s Dual Sim SM - A207F / DS 32GB 4G LTE Red", 1400m, (byte)0, null, (byte)0, null, 2, (byte)0 },
                    { 12, null, (byte)0, (byte)0, false, "phonecase.jpg", "X-Doria iPhone XS/X Case Defense Defense Shield Rose", 16m, (byte)0, null, (byte)0, null, 12, (byte)0 }
                });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "PhotoPath" },
                values: new object[] { "Ekran qoruyucuları", "screen_protector.jpg" });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "DVD və BLUE-RAY pleyerlər", "dvd_player.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "İPOD və MP3 pleyerlər", "ipod.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Televizorlar", "tv.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Noutbuklar", "Laptops.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Masaüstü kompüterlər", "Desktops.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Printerlər və çoxfunksiyalı avadanlıqlar", "Printers.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Monitorlar", "Monitors.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "USB flash kartlar", "usb_flash.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Operativ yaddaşlar", "memory_ram.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Daxili sərt disklər (HDD)", "hard_drivers.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Xüsusi qələmlər", "Styluses.jpg", 7 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Məlumat saxlama qurğuları", "storage.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Routerlər", "Routers.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Oyun konsolları", "Consoles.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Oyun nəzarətçiləri", "controller.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Video oyunlar", "games.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Fotokameralar", "Cameras.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Foto obyektivlər", "Lenses.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "VideoKameralar", "Camcorders.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Soyuducular", "Refrigerators.jpg", 11 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Qaz sobaları", "gas.jpg", 11 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Ütülər", "irons.jpg", 12 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Kondisionerlər", "conditioners.jpg", 12 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Tərəzilər", "Scales.jpg", 13 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Epilyatorlar", "Epilators.jpg", 13 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Kişi ətirləri", "men.jpg", 14 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Qadın ətirləri", "women.jpg", 14 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Masa örtüyü", "masa.jpg", 15 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Mətbəx tekstili", "kitchen.jpg", 15 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Qabyuyan aksessuarları", "dish_acss.jpg", 16 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Qazanlar və tavalar", "dishes.jpg", 16 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "İş lampaları", "lamp.jpg", 17 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Kreslolar", "kreslo.jpg", 17 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "Products",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShipDate",
                table: "Products",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "Products",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "PhotoPath" },
                values: new object[] { "Sport bilərzikləri", "fit_watch.jpg" });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Enerji bankları", "portable_charger.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Portativ səs qurğular", "speaker.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Adapterlər", "charger.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Selfi çubuqları", "selfie.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Ekran qoruyucuları", "screen_protector.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Kabel və adapterlər", "cable.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "DVD və BLUE-RAY pleyerlər", "dvd_player.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "İPOD və MP3 pleyerlər", "ipod.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Televizorlar", "tv.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Noutbuklar", "Laptops.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Masaüstü kompüterlər", "Desktops.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Printerlər və çoxfunksiyalı avadanlıqlar", "Printers.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Monitorlar", "Monitors.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "USB flash kartlar", "usb_flash.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Operativ yaddaşlar", "memory_ram.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Daxili sərt disklər (HDD)", "hard_drivers.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Xüsusi qələmlər", "Styluses.jpg", 7 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Məlumat saxlama qurğuları", "storage.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Routerlər", "Routers.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Oyun konsolları", "Consoles.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Oyun nəzarətçiləri", "controller.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Video oyunlar", "games.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Fotokameralar", "Cameras.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Foto obyektivlər", "Lenses.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "VideoKameralar", "Camcorders.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Soyuducular", "Refrigerators.jpg", 11 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Qaz sobaları", "gas.jpg", 11 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Ütülər", "irons.jpg", 12 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Kondisionerlər", "conditioners.jpg", 12 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Tərəzilər", "Scales.jpg", 13 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Epilyatorlar", "Epilators.jpg", 13 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Kişi ətirləri", "men.jpg", 14 });

            migrationBuilder.UpdateData(
                table: "SubCategoryItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "PhotoPath", "SubCategoryId" },
                values: new object[] { "Qadın ətirləri", "women.jpg", 14 });

            migrationBuilder.InsertData(
                table: "SubCategoryItems",
                columns: new[] { "Id", "Name", "PhotoPath", "SubCategoryId" },
                values: new object[,]
                {
                    { 53, "İş lampaları", "lamp.jpg", 17 },
                    { 52, "Qazanlar və tavalar", "dishes.jpg", 16 },
                    { 51, "Qabyuyan aksessuarları", "dish_acss.jpg", 16 },
                    { 50, "Mətbəx tekstili", "kitchen.jpg", 15 },
                    { 54, "Kreslolar", "kreslo.jpg", 17 },
                    { 49, "Masa örtüyü", "masa.jpg", 15 }
                });
        }
    }
}
