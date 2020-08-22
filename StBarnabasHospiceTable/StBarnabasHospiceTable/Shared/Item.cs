using System;
using System.ComponentModel.DataAnnotations;

namespace StBarnabasHospiceTable.Shared
{
    //Model for table items
    public class Item
    {
        //Every property / value that an Item object holds.
        [Required]
        [StringLength(15, ErrorMessage = "Name too long.")]
        //Item Name property
        public string Name { get; set; }
        //Item Identification propery
        public int ItemId { get; set; }
        [StringLength(50, ErrorMessage = "Description too long.")]
        //Item Description property
        public string Description { get; set; }
        //Item Image property
        //Only accept image tags e.g. png, jpeg
        public string Image { get; set; }
    }
}
