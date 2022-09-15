using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeFriendyol.Models
{
    public class ManagerType
    {
        public int ID { get; set; }
        [Display(Name ="Isim")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        [StringLength(maximumLength:50, ErrorMessage ="Bu alan en fazla 50 karakter olabilir")]
        public string Name { get; set; }
        public virtual  ICollection<Manager> Managers { get; set; }

    }
}