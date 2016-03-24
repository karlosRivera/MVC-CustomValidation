using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AuthTest.Models
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }

    public class Hobby
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }

    public class SampleViewModel
    {
        [Display(Name = "Products")]
        public List<Product> Products { set; get; }

        [Required(ErrorMessage = "Select any Hobbies")]
        public List<Hobby> Hobbies { get; set; }

        [Required(ErrorMessage = "Select any Product")]
        public int SelectedProductId { set; get; }

        [Required(ErrorMessage = "Select Male or Female")]
        public string Gender { get; set; }
    }
}