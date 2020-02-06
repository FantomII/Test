using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Shop_test.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "Salmsung j4+", Price = 12300, Producer = "Salmsung" });
            context.Phones.Add(new Phone() { Name = "Salmsung j4", Price = 10300, Producer = "Salmsung" });
            context.Phones.Add(new Phone() { Name = "LG", Price = 8000, Producer = "LG" });
            base.Seed(context);
        }
    }
}