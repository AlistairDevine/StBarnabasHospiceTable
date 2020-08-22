using System.ComponentModel.DataAnnotations;
using System;

namespace StBarnabasHospiceTable.Shared
{
    //Model for the table
    public class Table
    {
        //Every property / value for a Table object.
        //Table Identification property
        public int TableId { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Title too long.")]
        //Table Title property
        public string Title { get; set; }
        [Required]
        //Table number of Rows property
        public int Rows { get; set; }
        [Required]
        //Table number of Columns property
        public int Columns { get; set; }
        //Reference to the Item that are going to be placed in the tables.
        public Item Item { get; set; }
    }
}
//Row / Column titles???
