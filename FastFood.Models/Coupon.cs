using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class Coupon
    {
        public int If { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public double Discount { get; set; }
        public double Minimumamount { get; set; }
        public byte[] CouponPicture { get; set; }
        public bool IsActives { get; set; }
    }
    public enum couponType
    {
        Precent=0,
        Currency=1
    }
}
