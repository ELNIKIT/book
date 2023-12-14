using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopWPF
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ClientID { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public int Access { get; set; }
	}



	public class Product
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int StockQuantity { get; set; }
		public string CategoryID { get; set; }
		public string ManufacturerID { get; set; }
		//public ICollection<ProductPhoto> ProductPhotos { get; set; }
	}

	public class Category
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CategoryID { get; set; }
		public string Name { get; set; }
		public ICollection<Product> Products { get; set; }
	}

	public class Manufacturer
	{
		[Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int ManufactererID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string ContactInfo { get; set; }
	}

	public class ProductPhoto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductPhotoID { get; set; }
		public string ProductID { get; set; }
		public string FilePath { get; set; }
		public Product Product { get; set; }
	}

	public class Cart
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		public int UserID { get; set; }
		public List<int> ProductID { get; set; }
	}

}
