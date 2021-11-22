using System;
using System.Collections.Generic;

#nullable disable

namespace ClothingStore.Models
{
    public partial class Produk
    {
        public int IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public string Ukuran { get; set; }
        public string Brand { get; set; }
    }
}
