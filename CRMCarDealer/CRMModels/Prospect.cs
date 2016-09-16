using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMModels
{//entityB la noi entityA este Contact
    public class Prospect
    {
        //Constructors
        public Prospect()
        {
            this.DriveTests = new List<DriveTest>();
        }

        [Key]
        public int ProspectId { get; set; }

        public string Name { get; set; }
        public string Details { get; set; }

        public Nullable<int> ContactId { get; set; }

 

        //Navigation Properties
        [ForeignKey("ContactId")]
        public virtual Contact Contact { get; set; }

        [InverseProperty("Prospect")]
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<DriveTest> DriveTests { get; set; }

    }
}