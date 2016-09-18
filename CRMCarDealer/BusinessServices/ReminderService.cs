using CRMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class ReminderService
    {
        public static void AddReminder(string _text,string _salesmanName,string _salesmanSurname,int _customerId)
        {
            CRMContext _context = new CRMContext();
            Reminder obj = new Reminder() { Text = _text };
            obj.Customer = new Customer() { CustomerId = _customerId };
            obj.Salesman = new Salesman() { Name = _salesmanName, Surname = _salesmanSurname };
            _context.Reminders.Add(obj);
            _context.SaveChanges();
        }
    }
}
