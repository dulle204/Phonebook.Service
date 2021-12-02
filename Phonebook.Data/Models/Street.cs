using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Data.Models
{
    public class Street
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual City City { get; set; }
    }
}
