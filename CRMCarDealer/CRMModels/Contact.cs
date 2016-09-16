using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        public string Mail { get; set; }
        public string Telephone { get; set; }

        //Navigation Properties
        public virtual User User { get; set; }
        public virtual Prospect Prospect { get; set; }
    }
}