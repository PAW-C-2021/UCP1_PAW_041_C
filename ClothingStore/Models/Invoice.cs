using System;
using System.Collections.Generic;

#nullable disable

namespace ClothingStore.Models
{
    public partial class Invoice
    {
        public int IdOrder { get; set; }
        public string NamaSeller { get; set; }
        public string NamaPembeli { get; set; }
        public int? IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public int? TotalHarga { get; set; }
    }
}
