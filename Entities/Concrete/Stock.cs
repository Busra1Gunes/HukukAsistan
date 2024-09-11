﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Stock : IEntity
    {

        public int Id { get; set; }
        //Tedarikçi Kimliği
        public int SupplierID { get; set; }
        public string StockName { get; set; }
        //Miktar
        public int? Quantity { get; set; }
        //Birim Fiyat
        public decimal? UnitPrice { get; set; }
        //Toplam Değer
        public int? TotalValue { get; set; }
        //Açıklama
        public string? Description { get; set; }
        public DateTime? DateAdded { get; set; }
        public bool Status { get; set; }

        //Stok Hareketleri
        public ICollection<Stock_Movement> Stock_Movements { get; set; }

    }
}
