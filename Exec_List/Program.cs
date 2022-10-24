using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exec_List
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 宣告一個 List<Product> 變數, 存放多筆購買商品
			Product product1 = new Product()
			{
				Name = "蘋果",
				Price = 15,
				Amount = 2,
			};
			Product product2 = new Product()
			{
				Name = "香蕉",
				Price = 18,
				Amount = 5,
			};
			List<Product> product3 = new List<Product>
			{
				new Product{Name="Allen", Price=25, Amount = 2},
				new Product{Name="Allen", Price=10, Amount = 1},

			};
		}
		class Product
		{
			public string Name { get; set; }
			public int Price { get; set; }
			public int Amount { get; set; }
		}
	}
}
