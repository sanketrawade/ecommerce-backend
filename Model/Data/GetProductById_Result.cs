//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Data
{
    using System;
    
    public partial class GetProductById_Result
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<int> Price { get; set; }
        public string Cateogory { get; set; }
        public string SubCategory { get; set; }
        public long SubCategoryID { get; set; }
        public long CategoryId { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> Quentity { get; set; }
    }
}
