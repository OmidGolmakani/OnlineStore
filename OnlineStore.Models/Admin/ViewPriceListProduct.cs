using OnlineStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.Admin
{
    public class ViewPriceListProduct
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int Price { get; set; }
        public string Guarantee { get; set; }
        public bool IsAvailable { get; set; }
        public PriceListProductType PriceListProductType { get; set; }
    }
}
