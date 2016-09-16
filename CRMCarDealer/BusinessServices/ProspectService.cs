using CRMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class ProspectService
    {
        public static void AddProspect(string _name, string _details, string _email, string _telephone)
        {
            CRMContext crm = new CRMContext();
            Prospect obj = new Prospect() { Name = _name, Details = _details };
            obj.Contact = new Contact() { Mail = _email, Telephone = _telephone };

            crm.Prospects.Add(obj);
            crm.SaveChanges();

        }
    }
}
