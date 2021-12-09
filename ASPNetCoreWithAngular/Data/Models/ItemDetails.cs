using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWithAngular.Data.Models
{
    public class ItemDetails
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Required]
        [Display(Name = "Item Price")]
        public int? ItemPrice { get; set; }

        [Required]
        [Display(Name = "Image Name")]
        public string ImageName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int? Quantity { get; set; }

        [Required]
        [Display(Name = "AddedBy")]
        public string AddedBy { get; set; }
    }
}
