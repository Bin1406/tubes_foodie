using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Foodieee
{
	class ContohClassMakanan
	{
		public String nama { get; set; }
		public String harga { get; set; }
		public String nama2 { get; set; }
		public String harga2 { get; set; }
		public String nama3 { get; set; }
		public String harga3 { get; set; }
		public String satuan { get; set; }

		public ContohClassMakanan() { 
		
		}
/*
		public ContohClassMakanan(String nama, String harga, String satuan)
		{
			this.nama = nama;
			this.harga = harga;
			this.satuan = satuan;
		}
*/
	}

}
