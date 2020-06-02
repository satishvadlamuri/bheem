using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMCodingTest
{
    public class PromotionsModel
    {
        public int AItemCount { get; set; }
        public int BItemCount { get; set; }
        public int CItemCount { get; set; }
        public int DItemCount { get; set; }
        public int TotalPriceA { get; set; }
        public int TotalPriceD { get; set; }
        public int TotalPriceC { get; set; }
        public int TotalPriceB { get; set; }
        public int TotalPrice { get; internal set; }
    }
}
