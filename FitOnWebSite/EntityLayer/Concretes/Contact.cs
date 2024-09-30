using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Contact
    {
        public int ID { get; set; }

        public string PersonName { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}
