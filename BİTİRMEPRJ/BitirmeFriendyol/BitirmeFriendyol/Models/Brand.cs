using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeFriendyol.Models
{
    public class Brand
    {
        public int ID { get; set; }
        [Display(Name ="Marka")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        [StringLength(maximumLength:50, ErrorMessage = "Bu alan en fazla 50 karakter olabilir")]
        public string Name { get; set; }
        [Display(Name ="Durum")]
        public bool Status { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}