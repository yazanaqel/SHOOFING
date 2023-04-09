using OnTest.Code;
using OnTest.Data.Services;
using OnTest.Models;
using System.Runtime.Intrinsics.Arm;

namespace OnTest.Data.Repository
{
    public class ProductEntity : IDataHelper<Product>
    {

        static List<Product> productsList { get; }

        static ProductEntity()
        {
            productsList = new List<Product>
            {
                new Product{Id=1,Name="WOVEN SHOPPER BAG",Description="Paper tote bag. Contrasting colored trim. Shoulder straps..",ImageURL="https://static.zara.net/photos///2023/V/1/1/p/6260/110/713/2/w/199/6260110713_6_1_1.jpg?ts=1679309495349",Price=35,ProductCompany=Enums.ProductCompany.ZARA,ProductCategory=Enums.ProductCategory.Clothes},
                new Product{Id=2,Name="Rexona",Description="Men’s antiperspirant deodorant stick with up to 48 hours of motion-activated protection and a masculine scent..",ImageURL="https://asset-apac.unileversolutions.com/content/dam/unilever/rexona/malaysia/pack_shot/front/deodorants_and_fragrances/deodorants/rexona_men_xtra_cool_spray_150ml/xtra_cool_packshot_spray-1190716-png.png.ulenscale.400x385.png",Price=4,ProductCompany=Enums.ProductCompany.Rexona,ProductCategory=Enums.ProductCategory.Beauty},
                new Product{Id=3,Name="Optimum Nutrition Gold Standard 100% Whey",Description="An Optimum Nutrition Product\r\nThe Standard by Which All Other Whey Proteins are Measured",ImageURL="https://yazanaqel.github.io/Images/products/protein.jpg",Price=87,ProductCompany=Enums.ProductCompany.MuscleandStrength,ProductCategory=Enums.ProductCategory.Gym},
                new Product{Id=4,Name="BRAVIA XR",Description="Discover & shop Sony TV’s offering a wide variety of features ranging from smart TVs with 4K HDR Full Array LED to standard HD with Wi-Fi capabilities.",ImageURL="https://yazanaqel.github.io/Images/products/tv.jpg",Price=1099,ProductCompany=Enums.ProductCompany.SONY,ProductCategory=Enums.ProductCategory.Technology},
                new Product{Id=5,Name="AirPods",Description="AirPods are wireless earbuds made by Apple.",ImageURL="https://yazanaqel.github.io/Images/products/airpods.png",Price=1200,ProductCompany=Enums.ProductCompany.Apple,ProductCategory=Enums.ProductCategory.Technology},
                new Product{Id=6,Name="Jeans",Description="If there is an acclaimed, on-trend and iconic garment, it's certainly men's jeans. The edit is all about maximum style with minimum effort, which is why ZARA's jeans bring a laid-back vibe for flawless everyday looks without the hassle.",ImageURL="https://yazanaqel.github.io/Images/products/jeans.jpg",Price=15,ProductCompany=Enums.ProductCompany.ZARA,ProductCategory=Enums.ProductCategory.Clothes},
				new Product{Id=7,Name="Surface 8 Pro",Description="Unlock more possibilities than ever with the Pro designed for a Pro like you. The first Surface Pro built on the Intel® Evo™ platform on select configurations†† and designed to light up the best of Windows 11.",ImageURL="https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RE4P7Wb?ver=24e9&q=90&m=6&h=705&w=1253&b=%23FFFFFFFF&f=jpg&o=f&p=140&aim=true",Price=899,ProductCompany=Enums.ProductCompany.Microsoft,ProductCategory=Enums.ProductCategory.Technology},
				new Product{Id=8,Name="Dove Shampoo",Description="There’s so much more to shampoo than just ‘getting clean.’That’s why, with Dove shampoo products, hair gets the nourishing care it needs, along with gentle cleansing power.",ImageURL="https://yazanaqel.github.io/Images/products/dove.jpg",Price=10,ProductCompany=Enums.ProductCompany.Dove,ProductCategory=Enums.ProductCategory.Beauty},
				new Product{Id=9,Name="S23 Ultra",Description="We've raised the bar with a 200MP camera and our fastest mobile processor ever.",ImageURL="https://image-us.samsung.com/SamsungUS/configurator/S23U-V2-Configurator-DT-800x600.jpg?$product-details-jpg$",Price=1199,ProductCompany=Enums.ProductCompany.Samsung,ProductCategory=Enums.ProductCategory.Technology},
				new Product{Id=10,Name="Adidas NMD_V3 SHOES",Description="This product is excluded from all promotional discounts and offers.",ImageURL="https://assets.adidas.com/images/w_383,h_383,f_auto,q_auto,fl_lossy,c_fill,g_auto/bc5dc753b5c04601be45af9c01506adc_9366/nmd_v3-shoes.jpg",Price=170,ProductCompany=Enums.ProductCompany.Adidas,ProductCategory=Enums.ProductCategory.Sport},
				new Product{Id=11,Name="Bluetooth Keyboard",Description="Arteck HB192 Universal Bluetooth Keyboard Multi-Device Stainless Steel Full Size Wireless Keyboard for Windows iOS Android Computer Desktop Laptop Surface Tablet Smartphone Rechargeable Battery.",ImageURL="https://m.media-amazon.com/images/I/61SA55i13eL._AC_SX679_.jpg",Price=24,ProductCompany=Enums.ProductCompany.Amazon,ProductCategory=Enums.ProductCategory.Technology},
				new Product{Id=12,Name="",Description="",ImageURL="",Price=15,ProductCompany=Enums.ProductCompany.ZARA,ProductCategory=Enums.ProductCategory.Clothes},
                new Product{Id=13,Name="",Description="",ImageURL="",Price=899,ProductCompany=Enums.ProductCompany.Microsoft,ProductCategory=Enums.ProductCategory.Technology},
				new Product{Id=14,Name="",Description="",ImageURL="",Price=10,ProductCompany=Enums.ProductCompany.Dove,ProductCategory=Enums.ProductCategory.Beauty},
				new Product{Id=15,Name="",Description="",ImageURL="",Price=87,ProductCompany=Enums.ProductCompany.MuscleandStrength,ProductCategory=Enums.ProductCategory.Gym},
				new Product{Id=16,Name="",Description="",ImageURL="",Price=1099,ProductCompany=Enums.ProductCompany.SONY,ProductCategory=Enums.ProductCategory.Technology},
				new Product{Id=17,Name="",Description="",ImageURL="",Price=1200,ProductCompany=Enums.ProductCompany.Apple,ProductCategory=Enums.ProductCategory.Technology},

			};
        }

        public Product Find(int id) => productsList.FirstOrDefault(x => x.Id == id);

        public List<Product> GetAllData() => productsList;


        public List<Product> Search(string searchItem)
        {
            var result = productsList.Where
            (a => a.Name.Contains(searchItem)).ToList();

            return result;
        }

        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

		public void Apply()
		{
			throw new NotImplementedException();
		}
	}
}

