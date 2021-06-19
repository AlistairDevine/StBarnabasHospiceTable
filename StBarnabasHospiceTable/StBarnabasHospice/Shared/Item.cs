using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StBarnabasHospice.Shared
{
    //Model for table items
    public class Item
    {
        //Every property / value that an Item object holds.
        [Required]
        [StringLength(50, ErrorMessage = "Name too long.")]
        //Item Name property
        public string Name { get; set; }
        //Item Identification propery
        public int Id { get; set; }
        [StringLength(200, ErrorMessage = "Description too long.")]
        //Item Description property
        public string Description { get; set; }
        //Item Image property
        //Only accept image tags e.g. png, jpeg

        public string Image { get; set; }
    }

}
