using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "名称")]
        public string CategoryName { get; set; }

        [Display(Name = " 描述")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}