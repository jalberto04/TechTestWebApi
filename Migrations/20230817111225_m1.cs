using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechTestWebApi.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 1, "An apple mobile which is nothing like apple", "iPhone 9", 549.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 2, "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", "iPhone X", 899.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 3, "Samsung's new variant which goes beyond Galaxy to the Universe", "Samsung Universe 9", 1249.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 4, "OPPO F19 is officially announced on April 2021.", "OPPOF19", 280.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 5, "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", "Huawei P30", 499.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 6, "MacBook Pro 2021 with mini-LED display may launch between September, November", "MacBook Pro", 1749.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 7, "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", "Samsung Galaxy Book", 1499.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 8, "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", "Microsoft Surface Laptop 4", 1499.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 9, "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", "Infinix INBOOK", 1099.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 10, "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", "HP Pavilion 15-DK1056WM", 1099.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 11, "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", "perfume Oil", 13.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 12, "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", "Brown Perfume", 40.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 13, "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", "Fog Scent Xpressio Perfume", 13.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 14, "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", "Non-Alcoholic Concentrated Perfume Oil", 120.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 15, "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", "Eau De Perfume Spray", 30.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 16, "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", "Hyaluronic Acid Serum", 19.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 17, "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", "Tree Oil 30ml", 12.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 18, "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", "Oil Free Moisturizer 100ml", 40.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 19, "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", "Skin Beauty Serum.", 46.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 20, "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", "Freckle Treatment Cream- 15gm", 70.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 21, "Fine quality Branded Product Keep in a cool and dry place", "- Daal Masoor 500 grams", 20.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 22, "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", "Elbow Macaroni - 400 gm", 14.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 23, "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", "Orange Essence Food Flavou", 14.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 24, "original fauji cereal muesli 250gm box pack original fauji cereals muesli fruit nuts flakes breakfast cereal break fast faujicereals cerels cerel foji fouji", "cereals muesli fruit nuts", 46.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 25, "Dry Rose Flower Powder Gulab Powder 50 Gram • Treats Wounds", "Gulab Powder 50 Gram", 70.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 26, "Boho Decor Plant Hanger For Home Wall Decoration Macrame Wall Hanging Shelf", "Plant Hanger For Home", 41.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 27, "Package Include 6 Birds with Adhesive Tape Shape: 3D Shaped Wooden Birds Material: Wooden MDF, Laminated 3.5mm", "Flying Wooden Bird", 51.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 28, "3D led lamp sticker Wall sticker 3d wall art light on/off button  cell operated (included)", "3D Embellishment Art Lamp", 20.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 29, "Handcraft Chinese style art luxury palace hotel villa mansion home decor ceramic vase with brass fruit plate", "Handcraft Chinese style", 60.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 30, "Attractive DesignMetallic materialFour key hooksReliable & DurablePremium Quality", "Key Holder", 30.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 31, "Mornadi Velvet Bed Base with Headboard Slats Support Classic Style Bedroom Furniture Bed Set", "Mornadi Velvet Bed", 40.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 32, "Ratttan Outdoor furniture Set Waterproof  Rattan Sofa for Coffe Cafe", "Sofa for Coffe Cafe", 50.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 33, "3 Tier Corner Shelves | 3 PCs Wall Mount Kitchen Shelf | Floating Bedroom Shelf", "3 Tier Corner Shelves", 700.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 34, "V﻿ery good quality plastic table for multi purpose now in reasonable price", "Plastic Table", 50.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 35, "Material: Stainless Steel and Fabric  Item Size: 110 cm x 45 cm x 175 cm Package Contents: 1 Storage Wardrobe", "3 DOOR PORTABLE", 41.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 36, "Cotton Solid Color Professional Wear Sleeve Shirt Womens Work Blouses Wholesale Clothing Casual Plain Custom Top OEM Customized", "Sleeve Shirt Womens", 90.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 37, "PACK OF 3 CAMISOLES ,VERY COMFORTABLE SOFT COTTON STUFF, COMFORTABLE IN ALL FOUR SEASONS", "ank Tops for Womens/Girls", 50.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 38, "sublimation plain kids tank tops wholesale", "sublimation plain kids tank", 100.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 39, "2021 Custom Winter Fall Zebra Knit Crop Top Women Sweaters Wool Mohair Cos Customize Crew Neck Women' S Crop Top Sweater", "Women Sweaters Wool", 600.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 40, "women winter clothes thick fleece hoodie top with sweat pantjogger women sweatsuit set joggers pants two piece pants set", "women winter clothes", 57.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 41, "NIGHT SUIT RED MICKY MOUSE..  For Girls. Fantastic Suits.", "NIGHT SUIT", 55.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 42, "FABRIC: LILEIN CHEST: 21 LENGHT: 37 TROUSER: (38) :ARABIC LILEIN", "Stiched Kurta plus trouser", 80.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 43, "Ghazi fabric long frock gold printed ready to wear stitched collection (G992)", "frock gold printed", 600.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 44, "This classy shirt for women gives you a gorgeous look on everyday wear and specially for semi-casual wears.", "Ladies Multicolored Dress", 79.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 45, "Ready to wear, Unique design according to modern standard fashion, Best fitting ,Imported stuff", "Malai Maxi Dress", 50.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 46, "Close: Lace, Style with bottom: Increased inside, Sole Material: Rubber", "women's shoes", 40.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 47, "Synthetic Leather Casual Sneaker shoes for Women/girls Sneakers For Women", "Sneaker shoes", 120.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 48, "Features: Flip-flops, Mid Heel, Comfortable, Striped Heel, Antiskid, Striped", "Women Strip Heel", 40.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 49, "Womens Chappals & Shoe Ladies Metallic Tong Thong Sandal Flat Summer 2020 Maasai Sandals", "Chappals & Shoe Ladies Metallic", 23.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 50, "2020 New Arrivals Genuine Leather Fashion Trend Platform Summer Women Shoes", "Women Shoes", 36.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 51, "Many store is creating new designs and trend every month and every year. Daraz.pk have a beautiful range of men fashion brands", "half sleeves T shirts", 23.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 52, "quality and professional print - It doesn't just look high quality, it is high quality.", "FREE FIRE T Shirt", 10.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 53, "Brand: vintage Apparel ,Export quality", "printed high quality T shirts", 35.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 54, "Product Description Features: 100% Ultra soft Polyester Jersey. Vibrant & colorful printing on front. Feels soft as cotton without ever cracking", "Pubg Printed Graphic T-Shirt", 46.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 55, "Fabric Jercy, Size: M & L Wear Stylish Dual Stiched", "Money Heist Printed Summer T Shirts", 66.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 56, "Gender: Men , Colors: Same as DisplayedCondition: 100% Brand New", "Sneakers Joggers Shoes", 40.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 57, "Men Shoes - Loafers for men - Rubber Shoes - Nylon Shoes - Shoes for men - Moccassion - Pure Nylon (Rubber) Expot Quality.", "Loafers for men", 47.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 58, "Pattern Type: Solid, Material: PU, Toe Shape: Pointed Toe ,Outsole Material: Rubber", "formal offices shoes", 57.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 59, "Comfortable stretch cloth, lightweight body; ,rubber sole, anti-skid wear;", "Spring and summershoes", 20.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 60, "High Quality ,Stylish design ,Comfortable wear ,FAshion ,Durable", "Stylish Casual Jeans Shoes", 58.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 61, "Style:Sport ,Clasp:Buckles ,Water Resistance Depth:3Bar", "Leather Straps Wristwatch", 120.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 62, "Watch Crown With Environmental IPS Bronze Electroplating; Display system of 12 hours", "Waterproof Leather Brand Watch", 46.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 63, "Men Silver Chain Royal Blue Premium Watch Latest Analog Watch", "Royal Blue Premium Watch", 50.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 64, "Leather Strap Skeleton Watch for Men - Stylish and Latest Design", "Leather Strap Skeleton Watch", 46.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 65, "Stylish Watch For Man (Luxury) Classy Men's Stainless Steel Wrist Watch - Box Packed", "Stainless Steel Wrist Watch", 47.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 66, "Elegant design, Stylish ,Unique & Trendy,Comfortable wear", "Steel Analog Couple Watches", 35.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 67, "Buy this awesome  The product is originally manufactured by the company and it's a top selling product with a very reasonable", "Fashion Magnetic Wrist Watch", 60.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 68, "Stylish Luxury Digital Watch For Girls / Women - Led Smart Ladies Watches For Girls", "Stylish Luxury Digital Watch", 57.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 69, "Product details of Golden Watch Pearls Bracelet Watch For Girls - Golden Chain Ladies Bracelate Watch for Women", "Golden Watch Pearls Bracelet Watch", 47.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 70, "Fashion Skmei 1830 Shell Dial Stainless Steel Women Wrist Watch Lady Bracelet Watch Quartz Watches Ladies", "Stainless Steel Women", 35.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
