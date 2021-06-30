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
		public int harga { get; set; }
		public String satuan { get; set; }

		public ContohClassMakanan() { 
		
		}

		public ContohClassMakanan(String nama, int harga, String satuan)
		{
			this.nama = nama;
			this.harga = harga;
			this.satuan = satuan;
		}
	}

}
