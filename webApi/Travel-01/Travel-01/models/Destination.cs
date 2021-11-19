using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel_01.models
{
    public class Destination
    {
        public int ListingID { get; set; }
        public int AcctId { get; set; }
        public int AccountID { get; set; }
        public string Company { get; set; }
        public string Company_SortBy { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Image_List { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public DateTime DateCreated { get; set; }
        public string SortKey { get; set; }
        public bool Active { get; set; }
        public bool ContainDeals { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Misc1 { get; set; }
        public string Misc2 { get; set; }
        public string Misc3 { get; set; }
        public string Misc4 { get; set; }
        public string Misc5 { get; set; }
        public string Misc6 { get; set; }
        public string Misc8 { get; set; }
    }
}
